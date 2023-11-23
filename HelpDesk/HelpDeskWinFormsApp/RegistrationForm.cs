using HelpDesk.Common;
using HelpDesk.Common.Models;
using System.Linq;
using System.Windows.Forms;

namespace HelpDeskWinFormsApp
{
    public partial class RegistrationForm : Form
    {
        private readonly IProvider provider;

        public RegistrationForm(IProvider provider)
        {
            InitializeComponent();

            this.provider = provider;
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel || DialogResult == DialogResult.Abort)
            {
                return;
            }

            var user = new User
            {
                Name = nameTextBox.Text,
                Login = loginTextBox.Text,
                Password = Methods.GetHashMD5(passwordTextBox.Text),
                Email = emailTextBox.Text
            };

            provider.AddUser(user);
        }
    }
}
