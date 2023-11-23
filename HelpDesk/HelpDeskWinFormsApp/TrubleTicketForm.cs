using HelpDesk.Common;
using HelpDesk.Common.Models;
using System.Windows.Forms;

namespace HelpDeskWinFormsApp
{
    public partial class TrubleTicketForm : Form
    {
        int ticketId;
        TrubleTicket trubleTicket;
        User userCreate;
        bool isEmployee;
        int resolveUserId;
        string lastStatus;
        private readonly IProvider provider;

        public TrubleTicketForm(int ticketId, bool isEmployee, int resolveUserId, IProvider provider)
        {
            InitializeComponent();
            this.ticketId = ticketId;
            this.isEmployee = isEmployee;
            this.resolveUserId = resolveUserId;
            this.provider = provider;
        }

        private void TrubleTicketForm_Shown(object sender, System.EventArgs e)
        {
            trubleTicket = provider.GetTrubleTicket(ticketId);
            userCreate = provider.GetUser(trubleTicket.CreateUser);
            lastStatus = trubleTicket.Status;

            Text = $"HelpDesk. Заяка №{trubleTicket.Id}";
            userCreateTextBox.Text = $"{userCreate.Name} \\ {userCreate.Email}";
            trubleTicketRichTextBox.Text = trubleTicket.Text;
            statusTrubleTicketComboBox.Text = trubleTicket.Status;

            if (trubleTicket.Resolve != null)
            {
                resolveRichTextBox.Text = $"Заявка решена {trubleTicket.ResolveTime}\n\r";
                resolveRichTextBox.Text += trubleTicket.Resolve;
                resolveRichTextBox.ReadOnly = true;
                statusTrubleTicketComboBox.Enabled = false;
                saveButton.Enabled = false;
            }

            if (!isEmployee)
            {
                saveButton.Visible = false;
                resolveRichTextBox.Enabled = false;
                statusTrubleTicketComboBox.Enabled = false;
            }
        }

        private void TrubleTicketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (resolveRichTextBox.Text == string.Empty && (statusTrubleTicketComboBox.Text == "Выполнена" || statusTrubleTicketComboBox.Text == "Отклонена"))
                {
                    e.Cancel = true;
                    MessageBox.Show("Пожалуйста заполните решение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (statusTrubleTicketComboBox.Text != lastStatus)
                {
                    if (statusTrubleTicketComboBox.Text == "Выполнена" || statusTrubleTicketComboBox.Text == "Отклонена")
                    {
                        provider.ResolveTrubleTicket(trubleTicket.Id, statusTrubleTicketComboBox.Text, resolveRichTextBox.Text, resolveUserId);
                    }
                    else if (statusTrubleTicketComboBox.Text == "Зарегистрирована" && lastStatus != "Зарегистрирована")
                    {
                        e.Cancel = true;
                        MessageBox.Show("Возврат в статус \"Зарегистрирована\" запрещён.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        provider.ChangeStatusTrubleTicket(trubleTicket.Id, statusTrubleTicketComboBox.Text, resolveUserId);
                    }
                }
            }
        }
    }
}
