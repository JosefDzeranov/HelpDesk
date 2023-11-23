namespace HelpDeskWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Все ТТ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Открытые ТТ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Закрытые ТТ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Просроченные ТТ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Зарегистрирован");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("В работе");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Выполнен");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Отклонен");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Статус ТТ", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Лента ТТ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode9});
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.userNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loginToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.editUserButton = new System.Windows.Forms.Button();
            this.addTrubleTicketbutton = new System.Windows.Forms.Button();
            this.openTrubleTicketButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.listTTDataGridView = new System.Windows.Forms.DataGridView();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userNameToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(982, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.userNameToolStripMenuItem.Text = "userName";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoutToolStripMenuItem.Text = "&Выйти";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.refreshToolStripMenuItem.Text = "&Обновить таблицу";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameToolStripStatusLabel,
            this.loginToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 634);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(982, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // userNameToolStripStatusLabel
            // 
            this.userNameToolStripStatusLabel.AutoSize = false;
            this.userNameToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.userNameToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.userNameToolStripStatusLabel.Name = "userNameToolStripStatusLabel";
            this.userNameToolStripStatusLabel.Size = new System.Drawing.Size(150, 17);
            this.userNameToolStripStatusLabel.Text = "Имя:";
            this.userNameToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginToolStripStatusLabel
            // 
            this.loginToolStripStatusLabel.AutoSize = false;
            this.loginToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.loginToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.loginToolStripStatusLabel.Name = "loginToolStripStatusLabel";
            this.loginToolStripStatusLabel.Size = new System.Drawing.Size(150, 17);
            this.loginToolStripStatusLabel.Text = "Логин:";
            this.loginToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.editUserButton);
            this.splitContainer.Panel1.Controls.Add(this.addTrubleTicketbutton);
            this.splitContainer.Panel1.Controls.Add(this.openTrubleTicketButton);
            this.splitContainer.Panel1.Controls.Add(this.exitButton);
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Resize += new System.EventHandler(this.SplitContainer_Panel1_Resize);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listTTDataGridView);
            this.splitContainer.Panel2.Resize += new System.EventHandler(this.SplitContainer_Panel2_Resize);
            this.splitContainer.Size = new System.Drawing.Size(982, 610);
            this.splitContainer.SplitterDistance = 168;
            this.splitContainer.TabIndex = 2;
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(3, 493);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(158, 23);
            this.editUserButton.TabIndex = 4;
            this.editUserButton.Text = "&Изменить пользователя";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // addTrubleTicketbutton
            // 
            this.addTrubleTicketbutton.Location = new System.Drawing.Point(3, 551);
            this.addTrubleTicketbutton.Name = "addTrubleTicketbutton";
            this.addTrubleTicketbutton.Size = new System.Drawing.Size(158, 23);
            this.addTrubleTicketbutton.TabIndex = 3;
            this.addTrubleTicketbutton.Text = "&Создать заявку";
            this.addTrubleTicketbutton.UseVisualStyleBackColor = true;
            this.addTrubleTicketbutton.Click += new System.EventHandler(this.AddTrubleTicketbutton_Click);
            // 
            // openTrubleTicketButton
            // 
            this.openTrubleTicketButton.Location = new System.Drawing.Point(3, 522);
            this.openTrubleTicketButton.Name = "openTrubleTicketButton";
            this.openTrubleTicketButton.Size = new System.Drawing.Size(158, 23);
            this.openTrubleTicketButton.TabIndex = 2;
            this.openTrubleTicketButton.Text = "&Открыть ТТ";
            this.openTrubleTicketButton.UseVisualStyleBackColor = true;
            this.openTrubleTicketButton.Click += new System.EventHandler(this.OpenTrubleTicketButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 580);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(158, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "allTrubleTicket";
            treeNode1.Text = "Все ТТ";
            treeNode2.Name = "openTrubleTicket";
            treeNode2.Text = "Открытые ТТ";
            treeNode3.Name = "closedTrubleTicket";
            treeNode3.Text = "Закрытые ТТ";
            treeNode4.Name = "overdueTrubleTicketNode";
            treeNode4.Text = "Просроченные ТТ";
            treeNode5.Name = "registeredTrubleTicketNode";
            treeNode5.Text = "Зарегистрирован";
            treeNode6.Name = "workTrubleTicketNode";
            treeNode6.Text = "В работе";
            treeNode7.Name = "completedTrubleTicketNode";
            treeNode7.Text = "Выполнен";
            treeNode8.Name = "rejectedTrubleTicketNode";
            treeNode8.Text = "Отклонен";
            treeNode9.Name = "statusTrubleTicketNode";
            treeNode9.Text = "Статус ТТ";
            treeNode10.Name = "trubleTicketlist";
            treeNode10.Text = "Лента ТТ";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView.Size = new System.Drawing.Size(166, 449);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // listTTDataGridView
            // 
            this.listTTDataGridView.AllowUserToAddRows = false;
            this.listTTDataGridView.AllowUserToDeleteRows = false;
            this.listTTDataGridView.AllowUserToResizeRows = false;
            this.listTTDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.listTTDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.listTTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTTDataGridView.Location = new System.Drawing.Point(0, 0);
            this.listTTDataGridView.MultiSelect = false;
            this.listTTDataGridView.Name = "listTTDataGridView";
            this.listTTDataGridView.ReadOnly = true;
            this.listTTDataGridView.RowHeadersVisible = false;
            this.listTTDataGridView.RowTemplate.Height = 25;
            this.listTTDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listTTDataGridView.Size = new System.Drawing.Size(811, 588);
            this.listTTDataGridView.TabIndex = 0;
            this.listTTDataGridView.DoubleClick += new System.EventHandler(this.ListTTDataGridView_DoubleClick);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "&Экспорт";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 656);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpDesk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel userNameToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel loginToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView listTTDataGridView;
        private System.Windows.Forms.Button openTrubleTicketButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addTrubleTicketbutton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}