using System.Windows.Forms;

namespace HelpDeskWinFormsApp
{
    partial class AuthorizationFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            cancelButton = new Button();
            registrationButton = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Enabled = false;
            LoginTextBox.Location = new System.Drawing.Point(12, 75);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new System.Drawing.Size(279, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Enabled = false;
            PasswordTextBox.Location = new System.Drawing.Point(12, 139);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new System.Drawing.Size(279, 23);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(279, 30);
            label1.TabIndex = 2;
            label1.Text = "&Логин";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 101);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(279, 35);
            label2.TabIndex = 3;
            label2.Text = "&Пароль";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.DialogResult = DialogResult.OK;
            loginButton.Enabled = false;
            loginButton.Location = new System.Drawing.Point(12, 202);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(279, 33);
            loginButton.TabIndex = 4;
            loginButton.Text = "&Вход";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(12, 280);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(279, 33);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "В&ыход";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // registrationButton
            // 
            registrationButton.Enabled = false;
            registrationButton.Location = new System.Drawing.Point(12, 241);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new System.Drawing.Size(279, 33);
            registrationButton.TabIndex = 6;
            registrationButton.Text = "&Регистрация";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += RegistrationButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(303, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "&Выход";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // AuthorizationFrom
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new System.Drawing.Size(303, 328);
            ControlBox = false;
            Controls.Add(registrationButton);
            Controls.Add(cancelButton);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "AuthorizationFrom";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Авторизация";
            FormClosing += AuthorizationFrom_FormClosing;
            Shown += AuthorizationFrom_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button loginButton;
        private Button cancelButton;
        public TextBox LoginTextBox;
        public TextBox PasswordTextBox;
        private Button registrationButton;
        private ContextMenuStrip contextMenuStrip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}