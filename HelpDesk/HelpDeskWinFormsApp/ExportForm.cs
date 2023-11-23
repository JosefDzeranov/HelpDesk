using ClosedXML.Excel;
using HelpDesk.Common;
using HelpDesk.Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelpDeskWinFormsApp
{
    public partial class ExportForm : Form
    {
        private List<string> statusFilter = new List<string>();
        private bool successfullyExport = false;
        private DialogResult exportFileDialogResult = DialogResult.Cancel;
        private bool isSupport = false;
        private readonly IProvider provider;

        public ExportForm(bool isSupport, IProvider provider)
        {
            InitializeComponent();

            this.provider = provider;
            this.isSupport = isSupport;
            this.provider = provider;
        }

        private void ExportForm_Shown(object sender, EventArgs e)
        {
            fileTypeComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
            exportFileDialog.InitialDirectory = Environment.CurrentDirectory;
            startDateTimePicker.Value = DateTime.Now.AddDays(-1);
            endDateTimePicker.Value = DateTime.Now;
            statusFilterComboBox.Enabled = false;

            if (isSupport)
            {
                typeComboBox.Items.RemoveAt(1);
                statusFilterCheckBox.Visible = false;
                statusFilterComboBox.Visible = false;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            successfullyExport = true;

            SetFilterFileExtension();

            exportFileDialog.FileName = $"export_{typeComboBox.Text}_{DateTime.Now.ToString("dd.MM.yyyy_HH-mm")}";
            exportFileDialogResult = exportFileDialog.ShowDialog();

            if (exportFileDialogResult == DialogResult.Cancel)
            {
                return;
            }

            var allTrubleTickets = provider.GetAllTrubleTickets();
            var trubleTickets = new List<TrubleTicket>();

            foreach ( var tt in allTrubleTickets)
            {
                if (tt.Created >= startDateTimePicker.Value && tt.Created <= endDateTimePicker.Value)
                {
                    trubleTickets.Add(tt);
                }
            }

            var users = provider.GetAllUsers();
            var exportFile = exportFileDialog.FileName;

            if (typeComboBox.Text == "Truble Ticket")
            {
                if (statusFilterCheckBox.Checked)
                {
                    var tempTrubleTickets = new List<TrubleTicket>();

                    foreach( var tt in trubleTickets)
                    {
                        if (tt.Status == statusFilterComboBox.Text)
                        {
                            tempTrubleTickets.Add(tt);
                        }
                    }

                    trubleTickets.Clear();
                    trubleTickets.AddRange(tempTrubleTickets);
                }

                if (trubleTickets.Count != 0)
                {
                    if (fileTypeComboBox.Text == "Excel (.xlsx)")
                    {
                        ExcelTrubleTicketExport(trubleTickets, users, exportFile);
                    }
                    else if (fileTypeComboBox.Text == "Comma-Separated Values (.csv)")
                    {
                        CsvTrubleTicketExport(trubleTickets, users, exportFile);
                    }
                }
                else
                {
                    successfullyExport = false;
                    MessageBox.Show("С выбранными фильтрами данные для экспорта отсутствуют", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (typeComboBox.Text == "Пользователи")
            {
                var onlyClientsExport = false;

                if (statusFilterCheckBox.Checked)
                {
                    if (statusFilterComboBox.Text == "Клиент")
                    {
                        users = users.Where(u => !u.IsEmployee).ToList();
                        onlyClientsExport = true;
                    }
                    else if (statusFilterComboBox.Text == "Сотрудник")
                    {
                        users = users.Where(u => u.IsEmployee).ToList();
                    }
                }

                if (users.Count != 0)
                {
                    if (fileTypeComboBox.Text == "Excel (.xlsx)")
                    {
                        ExcelUsersExport(users, exportFile, onlyClientsExport);
                    }
                    else if (fileTypeComboBox.Text == "Comma-Separated Values (.csv)")
                    {
                        CsvUsersExport(users, exportFile, onlyClientsExport);
                    }
                }
                else
                {
                    successfullyExport = false;
                    MessageBox.Show("С выбранными фильтрами данные для экспорта отсутствуют", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (successfullyExport)
            {
                Close();
            }
        }

        private void CsvTrubleTicketExport(List<TrubleTicket> result, List<User> users, string exportFile)
        {
            var rowsCount = result.Count;

            progressBar.Maximum = rowsCount;

            using (StreamWriter sw = new StreamWriter(exportFile, false, Encoding.UTF8))
            {
                sw.Write("\"Id\";");
                sw.Write("\"IsSolved\";");
                sw.Write("\"Status\";");
                sw.Write("\"Text\";");
                sw.Write("\"Resolve\";");
                sw.Write("\"ResolveUser\";");
                sw.Write("\"Created\";");
                sw.Write("\"ResolveTime\";");
                sw.Write("\"Deadline\";");
                sw.Write("\"Created\"\r\n");

                for (int i = 0; i < rowsCount; i++)
                {
                    progressBar.Value = i;
                    progressBar.PerformStep();

                    var resolveUser = users.Where(u => u.Id == result[i].ResolveUser).FirstOrDefault();
                    var createUser = users.Where(u => u.Id == result[i].CreateUser).FirstOrDefault();

                    sw.Write("\"" + result[i].Id + "\";");
                    sw.Write(result[i].IsSolved == true ? "\"Да\";" : "\"Нет\";");
                    sw.Write("\"" + result[i].Status + "\";");
                    sw.Write("\"" + result[i].Text.Trim('\r').Trim('\n') + "\";");
                    sw.Write("\"" + result[i].Resolve + "\";");
                    sw.Write(resolveUser == null ? "\"\";" : "\"" + resolveUser.Name + "\";");
                    sw.Write("\"" + result[i].Created + "\";");
                    sw.Write("\"" + result[i].ResolveTime + "\";");
                    sw.Write("\"" + result[i].Deadline + "\";");
                    sw.Write(createUser == null ? "\"\"\r\n" : "\"" + createUser.Name + "\"\r\n");
                }
            }
        }

        private void CsvUsersExport(List<User> users, string exportFile, bool onlyClients)
        {
            var userCount = users.Count;

            progressBar.Maximum = userCount;

            using (StreamWriter sw = new StreamWriter(exportFile, false, Encoding.UTF8))
            {
                sw.Write("\"Id\";");
                sw.Write("\"Name\";");
                sw.Write("\"Login\";");
                sw.Write("\"Email\";");
                sw.Write("\"Discriminator\"");

                if (!onlyClients)
                {
                    sw.Write(";\"Function\";");
                    sw.Write("\"Department\"\r\n");
                }
                else
                {
                    sw.Write("\r\n");
                }

                for (int i = 0; i < userCount; i++)
                {
                    var isEmployee = users[i].IsEmployee;

                    progressBar.Value = i;
                    progressBar.PerformStep();

                    sw.Write("\"" + users[i].Id + "\";");
                    sw.Write("\"" + users[i].Name + "\";");
                    sw.Write("\"" + users[i].Login + "\";");
                    sw.Write("\"" + users[i].Email + "\";");
                    sw.Write(isEmployee ? "\"Сотрудник\"" : "\"Клиент\"");

                    if (!onlyClients)
                    {
                        if (isEmployee)
                        {
                            sw.Write(";");
                            sw.Write("\"" + users[i].Function + "\";");
                            sw.Write("\"" + users[i].Department + "\"\r\n");
                        }
                        else
                        {
                            sw.Write(";\"\";\"\"\r\n");
                        }
                    }
                    else
                    {
                        sw.Write("\r\n");
                    }
                }
            }
        }

        private void SetFilterFileExtension()
        {
            if (fileTypeComboBox.Text == "Excel (.xlsx)")
            {
                exportFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Все файлы|*.*";
            }
            else if (fileTypeComboBox.Text == "Comma-Separated Values (.csv)")
            {
                exportFileDialog.Filter = "Comma-Separated Values (*.csv)|*.csv|Все файлы|*.*";
            }
        }

        private void ExcelUsersExport(List<User> users, string exportFile, bool onlyClients)
        {
            var userCount = users.Count;

            progressBar.Maximum = userCount;

            var workBook = new XLWorkbook();
            var sheet = workBook.Worksheets.Add(typeComboBox.Text);

            sheet.Cell(1, 1).SetValue("ID");
            sheet.Cell(1, 2).SetValue("Имя");
            sheet.Cell(1, 3).SetValue("Логин");
            sheet.Cell(1, 4).SetValue("E-Mail");
            sheet.Cell(1, 5).SetValue("Тип");
            sheet.Cell(1, 6).SetValue("Функция");
            sheet.Cell(1, 7).SetValue("Отдел");

            sheet.RangeUsed().AddConditionalFormat().WhenEquals("=A1:J1").Fill.SetBackgroundColor(XLColor.CarolinaBlue);

            for (int i = 0; i < userCount; i++)
            {
                progressBar.Value = i;
                progressBar.PerformStep();

                var isEmployee = users[i].IsEmployee;

                sheet.Cell(i + 2, 1).SetValue(users[i].Id);
                sheet.Cell(i + 2, 2).SetValue(users[i].Name);
                sheet.Cell(i + 2, 3).SetValue(users[i].Login);
                sheet.Cell(i + 2, 4).SetValue(users[i].Email);
                sheet.Cell(i + 2, 5).SetValue(isEmployee ? "Сотрудник" : "Клиент");
                sheet.Cell(i + 2, 6).SetValue(isEmployee ? users[i].Function : string.Empty);
                sheet.Cell(i + 2, 7).SetValue(isEmployee ? users[i].Department : string.Empty);
            }

            if (onlyClients)
            {
                sheet.Range("F1:G1").Delete(XLShiftDeletedCells.ShiftCellsLeft);
            }

            sheet.RangeUsed().SetAutoFilter();
            sheet.Columns().AdjustToContents();

            workBook.SaveAs(exportFile);
        }

        private void ExcelTrubleTicketExport(List<TrubleTicket> result, List<User> users, string exportFile)
        {
            var rowsCount = result.Count;

            progressBar.Maximum = rowsCount;

            var workBook = new XLWorkbook();
            var sheet = workBook.Worksheets.Add(typeComboBox.Text);

            sheet.Cell(1, 1).SetValue("ID");
            sheet.Cell(1, 2).SetValue("Решён");
            sheet.Cell(1, 3).SetValue("Статус");
            sheet.Cell(1, 4).SetValue("Текст");
            sheet.Cell(1, 5).SetValue("Решение");
            sheet.Cell(1, 6).SetValue("Решил");
            sheet.Cell(1, 7).SetValue("Создано");
            sheet.Cell(1, 8).SetValue("Дата решения");
            sheet.Cell(1, 9).SetValue("Крайний срок");
            sheet.Cell(1, 10).SetValue("Кем создано");
            sheet.RangeUsed().AddConditionalFormat().WhenEquals("=A1:J1").Fill.SetBackgroundColor(XLColor.CarolinaBlue);

            for (int i = 0; i < rowsCount; i++)
            {
                progressBar.Value = i;
                progressBar.PerformStep();

                var resolveUser = users.Where(u => u.Id == result[i].ResolveUser).FirstOrDefault();
                var createUser = users.Where(u => u.Id == result[i].CreateUser).FirstOrDefault();

                sheet.Cell(i + 2, 1).SetValue(result[i].Id);
                sheet.Cell(i + 2, 2).SetValue(result[i].IsSolved == true ? "Да" : "Нет");
                sheet.Cell(i + 2, 3).SetValue(result[i].Status);
                sheet.Cell(i + 2, 4).SetValue(result[i].Text);
                sheet.Cell(i + 2, 5).SetValue(result[i].Resolve);
                sheet.Cell(i + 2, 6).SetValue(resolveUser == null ? string.Empty : resolveUser.Name);
                sheet.Cell(i + 2, 7).SetValue(result[i].Created);
                sheet.Cell(i + 2, 8).SetValue(result[i].ResolveTime);
                sheet.Cell(i + 2, 9).SetValue(result[i].Deadline);
                sheet.Cell(i + 2, 10).SetValue(createUser == null ? string.Empty : createUser.Name);
            }

            sheet.RangeUsed().SetAutoFilter();
            sheet.Columns().AdjustToContents();
            workBook.SaveAs(exportFile);
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.Text == "Truble Ticket")
            {
                startDateTimePicker.Enabled = true;
                endDateTimePicker.Enabled = true;

                statusFilter.Clear();
                statusFilter.AddRange(new List<string>() { "Зарегистрирована", "В работе", "Выполнена", "Отклонена" });
                statusFilterComboBox.DataSource = null;
                statusFilterComboBox.DataSource = statusFilter;
            }
            else if (typeComboBox.Text == "Пользователи")
            {
                startDateTimePicker.Enabled = false;
                endDateTimePicker.Enabled = false;

                statusFilter.Clear();
                statusFilter.AddRange(new List<string>() { "Клиент", "Сотрудник" });
                statusFilterComboBox.DataSource = null;
                statusFilterComboBox.DataSource = statusFilter;
            }
        }

        private void StatusFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (statusFilterCheckBox.Checked)
            {
                statusFilterComboBox.Enabled = true;
            }
            else
            {
                statusFilterComboBox.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            successfullyExport = true;
            exportFileDialogResult = DialogResult.Abort;
            Close();
        }

        private void ExportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exportFileDialogResult == DialogResult.OK && successfullyExport)
            {
                MessageBox.Show("Данные успешно экспотированы", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!successfullyExport || exportFileDialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
