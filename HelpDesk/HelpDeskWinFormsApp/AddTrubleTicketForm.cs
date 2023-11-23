using HelpDesk.Common;
using HelpDesk.Common.Models;
using System;
using System.Windows.Forms;

namespace HelpDeskWinFormsApp
{
    public partial class AddTrubleTicketForm : Form
    {
        User user;
        private readonly IProvider provider;

        public AddTrubleTicketForm(User user, IProvider provider)
        {
            InitializeComponent();

            this.provider = provider;
            this.user = user;
        }

        private void AddTrubleTicketForm_Shown(object sender, EventArgs e)
        {
            userNameTextBox.Text = $"{user.Name} \\ {user.Login}";
        }

        private void AddTrubleTicketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                var trubelTicket = new TrubleTicket
                {
                    CreateUser = user.Id,
                    Text = trubleRichTextBox.Text,
                    Status = "Зарегистрирована",
                    Created = DateTime.Now,
                    Deadline = DateTime.Now.AddDays(4)
                };

                provider.AddTrubleTicket(trubelTicket);
            }
        }

        private void TrubleRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (trubleRichTextBox.Text.Length < 5)
            {
                createTrubleTicketButton.Enabled = false;
            }
            else
            {
                createTrubleTicketButton.Enabled = true;
            }
        }
    }
}
