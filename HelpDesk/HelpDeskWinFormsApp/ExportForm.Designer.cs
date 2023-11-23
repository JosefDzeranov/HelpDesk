namespace HelpDeskWinFormsApp
{
    partial class ExportForm
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
            this.fileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exportButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.statusFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.statusFilterComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип файла";
            // 
            // fileTypeComboBox
            // 
            this.fileTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileTypeComboBox.FormattingEnabled = true;
            this.fileTypeComboBox.Items.AddRange(new object[] {
            "Excel (.xlsx)",
            "Comma-Separated Values (.csv)"});
            this.fileTypeComboBox.Location = new System.Drawing.Point(121, 46);
            this.fileTypeComboBox.Name = "fileTypeComboBox";
            this.fileTypeComboBox.Size = new System.Drawing.Size(190, 23);
            this.fileTypeComboBox.TabIndex = 1;
            // 
            // exportFileDialog
            // 
            this.exportFileDialog.Filter = "Все файлы (*.*)|*.*";
            this.exportFileDialog.Title = "Экспорт";
            // 
            // exportButton
            // 
            this.exportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.exportButton.Location = new System.Drawing.Point(12, 232);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(299, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "&Экспорт";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(12, 261);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(299, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Временной интервал";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(12, 105);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(121, 23);
            this.startDateTimePicker.TabIndex = 5;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(190, 105);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(121, 23);
            this.endDateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Экспортировать";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Truble Ticket",
            "Пользователи"});
            this.typeComboBox.Location = new System.Drawing.Point(176, 16);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(135, 23);
            this.typeComboBox.TabIndex = 8;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // statusFilterCheckBox
            // 
            this.statusFilterCheckBox.AutoSize = true;
            this.statusFilterCheckBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusFilterCheckBox.Location = new System.Drawing.Point(12, 134);
            this.statusFilterCheckBox.Name = "statusFilterCheckBox";
            this.statusFilterCheckBox.Size = new System.Drawing.Size(207, 34);
            this.statusFilterCheckBox.TabIndex = 9;
            this.statusFilterCheckBox.Text = "&Фильтр по статусу";
            this.statusFilterCheckBox.UseVisualStyleBackColor = true;
            this.statusFilterCheckBox.CheckedChanged += new System.EventHandler(this.StatusFilterCheckBox_CheckedChanged);
            // 
            // statusFilterComboBox
            // 
            this.statusFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusFilterComboBox.FormattingEnabled = true;
            this.statusFilterComboBox.Location = new System.Drawing.Point(12, 174);
            this.statusFilterComboBox.Name = "statusFilterComboBox";
            this.statusFilterComboBox.Size = new System.Drawing.Size(299, 23);
            this.statusFilterComboBox.TabIndex = 10;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 203);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(299, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 11;
            // 
            // ExportForm
            // 
            this.AcceptButton = this.exportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 295);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusFilterComboBox);
            this.Controls.Add(this.statusFilterCheckBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.fileTypeComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpDesk. Экспорт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportForm_FormClosing);
            this.Shown += new System.EventHandler(this.ExportForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fileTypeComboBox;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.CheckBox statusFilterCheckBox;
        private System.Windows.Forms.ComboBox statusFilterComboBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}