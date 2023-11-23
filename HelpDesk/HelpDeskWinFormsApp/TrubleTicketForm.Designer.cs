namespace HelpDeskWinFormsApp
{
    partial class TrubleTicketForm
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
            this.userCreateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trubleTicketRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resolveRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusTrubleTicketComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кем создано";
            // 
            // userCreateTextBox
            // 
            this.userCreateTextBox.Location = new System.Drawing.Point(12, 31);
            this.userCreateTextBox.Name = "userCreateTextBox";
            this.userCreateTextBox.ReadOnly = true;
            this.userCreateTextBox.Size = new System.Drawing.Size(380, 23);
            this.userCreateTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текст обращения";
            // 
            // trubleTicketRichTextBox
            // 
            this.trubleTicketRichTextBox.Location = new System.Drawing.Point(12, 79);
            this.trubleTicketRichTextBox.Name = "trubleTicketRichTextBox";
            this.trubleTicketRichTextBox.ReadOnly = true;
            this.trubleTicketRichTextBox.Size = new System.Drawing.Size(380, 244);
            this.trubleTicketRichTextBox.TabIndex = 3;
            this.trubleTicketRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Решение";
            // 
            // resolveRichTextBox
            // 
            this.resolveRichTextBox.Location = new System.Drawing.Point(12, 348);
            this.resolveRichTextBox.Name = "resolveRichTextBox";
            this.resolveRichTextBox.Size = new System.Drawing.Size(380, 165);
            this.resolveRichTextBox.TabIndex = 5;
            this.resolveRichTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(12, 582);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(380, 37);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 625);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(380, 37);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Статус";
            // 
            // statusTrubleTicketComboBox
            // 
            this.statusTrubleTicketComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusTrubleTicketComboBox.FormattingEnabled = true;
            this.statusTrubleTicketComboBox.Items.AddRange(new object[] {
            "Зарегистрирована",
            "В работе",
            "Выполнена",
            "Отклонена"});
            this.statusTrubleTicketComboBox.Location = new System.Drawing.Point(12, 538);
            this.statusTrubleTicketComboBox.Name = "statusTrubleTicketComboBox";
            this.statusTrubleTicketComboBox.Size = new System.Drawing.Size(380, 23);
            this.statusTrubleTicketComboBox.TabIndex = 9;
            // 
            // TrubleTicketForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(404, 673);
            this.ControlBox = false;
            this.Controls.Add(this.statusTrubleTicketComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resolveRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trubleTicketRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userCreateTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrubleTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrubleTicketForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrubleTicketForm_FormClosing);
            this.Shown += new System.EventHandler(this.TrubleTicketForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userCreateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox trubleTicketRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox resolveRichTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusTrubleTicketComboBox;
    }
}