namespace HelpDeskWinFormsApp
{
    partial class RegistrationForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.replyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Имя";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(279, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Логин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 97);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(279, 23);
            this.loginTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 156);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(279, 23);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "&E-Mail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 274);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(279, 23);
            this.emailTextBox.TabIndex = 9;
            // 
            // registrationButton
            // 
            this.registrationButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.registrationButton.Location = new System.Drawing.Point(12, 316);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(279, 33);
            this.registrationButton.TabIndex = 10;
            this.registrationButton.Text = "&Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 355);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(279, 33);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "&Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.exitButton.Location = new System.Drawing.Point(12, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(279, 33);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Повторите пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replyPasswordTextBox
            // 
            this.replyPasswordTextBox.Location = new System.Drawing.Point(12, 215);
            this.replyPasswordTextBox.Name = "replyPasswordTextBox";
            this.replyPasswordTextBox.Size = new System.Drawing.Size(279, 23);
            this.replyPasswordTextBox.TabIndex = 7;
            this.replyPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.registrationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(303, 437);
            this.ControlBox = false;
            this.Controls.Add(this.replyPasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpDesk Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox replyPasswordTextBox;
    }
}