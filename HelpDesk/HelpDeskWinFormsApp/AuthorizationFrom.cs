using HelpDesk.Common;
using HelpDesk.Common.Models;
using System;
using System.Windows.Forms;

namespace HelpDeskWinFormsApp
{
    public partial class AuthorizationFrom : Form
    {
        public bool RegistrationChoice = false;
        private readonly IProvider provider;

        public AuthorizationFrom(IProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
        }

        private void AuthorizationFrom_Shown(object sender, EventArgs e)
        {
            AddFirstEmployee();
            UnlockTextBox();
        }

        private void AuthorizationFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (!provider.IsCorrectLoginPassword(LoginTextBox.Text, PasswordTextBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationChoice = true;
            cancelButton.PerformClick();
        }

        private void UnlockTextBox()
        {
            LoginTextBox.Enabled = true;
            PasswordTextBox.Enabled = true;
            loginButton.Enabled = true;
            registrationButton.Enabled = true;
        }

        private void AddFirstEmployee()
        {
            var isEmptyUsers = provider.GetAllUsers();

            if (isEmptyUsers == null || isEmptyUsers.Count == 0)
            {
                var employee = new User
                {
                    Name = "startAdmin",
                    Login = "admin",
                    Password = Methods.GetHashMD5("admin"),
                    Email = "admin@admin.admin",
                    IsEmployee = true,
                    Department = "Разработка",
                    Function = "Разработчик"
                };

                provider.AddUser(employee);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
