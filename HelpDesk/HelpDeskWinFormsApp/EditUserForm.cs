using HelpDesk.Common;
using HelpDesk.Common.Models;
using System;
using System.Windows.Forms;

namespace HelpDeskWinFormsApp
{
    public partial class EditUserForm : Form
    {
        int userId;
        User user;
        private readonly IProvider provider;

        public EditUserForm(int userId, IProvider provider)
        {
            InitializeComponent();
            this.userId = userId;
            this.provider = provider;
        }

        private void EditUserForm_Shown(object sender, EventArgs e)
        {
            user = provider.GetUser(userId);

            if (user.IsEmployee)
            {
                deparmentComboBox.Enabled = true;
                functionComboBox.Enabled = true;

                userTypeComboBox.Text = "Сотрудник";
                deparmentComboBox.Text = user.Department;
                functionComboBox.Text = user.Function;
            }
            else
            {
                deparmentComboBox.Enabled = false;
                functionComboBox.Enabled = false;

                userTypeComboBox.Text = "Клиент";
            }

            nameTextBox.Text = user.Name;
            loginTextBox.Text = user.Login;
            emailTextBox.Text = user.Email;
        }

        private void UserTypeComboBox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (userTypeComboBox.Text == "Сотрудник")
            {
                deparmentComboBox.Enabled = true;
                functionComboBox.Enabled = true;
            }
            else if (userTypeComboBox.Text == "Клиент")
            {
                deparmentComboBox.Enabled = false;
                functionComboBox.Enabled = false;
            }
        }

        private void EditUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.Name = nameTextBox.Text;
            user.Login = loginTextBox.Text;

            if (changePasswordTextBox.Text != string.Empty)
            {
                user.Password = Methods.GetHashMD5(changePasswordTextBox.Text);
            }

            user.Email = emailTextBox.Text;

            if (user.IsEmployee)
            {
                user.Function = functionComboBox.Text;
                user.Department = deparmentComboBox.Text;
            }

            if (userTypeComboBox.Text == "Сотрудник" && !user.IsEmployee)
            {
                provider.ChangeUserToEmployee(user, functionComboBox.Text, deparmentComboBox.Text);
            }
            else if (userTypeComboBox.Text == "Клиент" && user.IsEmployee)
            {
                provider.ChangeEmployeeToUser(user);
            }
            else
            {
                provider.UpdateUser(user);
            }
        }

        private void DeparmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (deparmentComboBox.Text == "Техническая поддержка")
            {
                functionComboBox.Items.Clear();
                functionComboBox.Items.Add("Оператор");
                functionComboBox.Items.Add("Технический специалист");
                functionComboBox.Text = "Оператор";
            }
            else if (deparmentComboBox.Text == "Разработка")
            {
                functionComboBox.Items.Clear();
                functionComboBox.Items.Add("Тестировщик");
                functionComboBox.Items.Add("Разработчик");
                functionComboBox.Text = "Тестировщик";
            }
        }
    }
}
