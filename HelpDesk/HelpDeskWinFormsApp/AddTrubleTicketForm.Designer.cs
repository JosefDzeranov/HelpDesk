namespace HelpDeskWinFormsApp
{
    partial class AddTrubleTicketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trubleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.createTrubleTicketButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(200, 16);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(190, 23);
            this.userNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Опишите вашу проблему";
            // 
            // trubleRichTextBox
            // 
            this.trubleRichTextBox.Location = new System.Drawing.Point(12, 75);
            this.trubleRichTextBox.Name = "trubleRichTextBox";
            this.trubleRichTextBox.Size = new System.Drawing.Size(378, 241);
            this.trubleRichTextBox.TabIndex = 3;
            this.trubleRichTextBox.Text = "";
            this.trubleRichTextBox.TextChanged += new System.EventHandler(this.TrubleRichTextBox_TextChanged);
            // 
            // createTrubleTicketButton
            // 
            this.createTrubleTicketButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createTrubleTicketButton.Enabled = false;
            this.createTrubleTicketButton.Location = new System.Drawing.Point(12, 322);
            this.createTrubleTicketButton.Name = "createTrubleTicketButton";
            this.createTrubleTicketButton.Size = new System.Drawing.Size(378, 34);
            this.createTrubleTicketButton.TabIndex = 4;
            this.createTrubleTicketButton.Text = "&Создать заявку";
            this.createTrubleTicketButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(378, 34);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddTrubleTicketForm
            // 
            this.AcceptButton = this.createTrubleTicketButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(402, 404);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createTrubleTicketButton);
            this.Controls.Add(this.trubleRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTrubleTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpDesk Создание заявки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTrubleTicketForm_FormClosing);
            this.Shown += new System.EventHandler(this.AddTrubleTicketForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox trubleRichTextBox;
        private System.Windows.Forms.Button createTrubleTicketButton;
        private System.Windows.Forms.Button cancelButton;
    }
}