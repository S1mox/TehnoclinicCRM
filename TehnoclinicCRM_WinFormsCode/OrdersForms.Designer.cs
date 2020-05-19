namespace TehnoclinicCRM_WinFormsCode
{
    partial class OrdersForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForms));
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.SearchCriteriaL = new System.Windows.Forms.Label();
            this.CriteriesBox = new System.Windows.Forms.ComboBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchL = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.StatusBox = new System.Windows.Forms.GroupBox();
            this.IsClosed = new System.Windows.Forms.CheckBox();
            this.IsRepairs = new System.Windows.Forms.CheckBox();
            this.IsFramed = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.вГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочники0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специалистыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SearchBox.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AllowUserToAddRows = false;
            this.OrdersGrid.AllowUserToDeleteRows = false;
            this.OrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.OrdersGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGrid.Location = new System.Drawing.Point(0, 30);
            this.OrdersGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersGrid.MultiSelect = false;
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGrid.Size = new System.Drawing.Size(1112, 573);
            this.OrdersGrid.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Snow;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(27, 43);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(214, 61);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SearchCriteriaL
            // 
            this.SearchCriteriaL.AutoSize = true;
            this.SearchCriteriaL.Location = new System.Drawing.Point(19, 24);
            this.SearchCriteriaL.Name = "SearchCriteriaL";
            this.SearchCriteriaL.Size = new System.Drawing.Size(118, 16);
            this.SearchCriteriaL.TabIndex = 7;
            this.SearchCriteriaL.Text = "Критерий поиска";
            // 
            // CriteriesBox
            // 
            this.CriteriesBox.FormattingEnabled = true;
            this.CriteriesBox.Items.AddRange(new object[] {
            "Номер заказа",
            "Дата получения",
            "Клиент",
            "Подразделение",
            "Услуга",
            "Предварительная цена",
            "Специалист",
            "Дата начала выполнения",
            "Дата окончания выполнения",
            "Итоговая сумма"});
            this.CriteriesBox.Location = new System.Drawing.Point(164, 21);
            this.CriteriesBox.Name = "CriteriesBox";
            this.CriteriesBox.Size = new System.Drawing.Size(161, 23);
            this.CriteriesBox.TabIndex = 8;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(164, 48);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(161, 23);
            this.SearchText.TabIndex = 9;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Location = new System.Drawing.Point(19, 51);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(92, 16);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Строка ввода";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(21, 84);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(304, 34);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.StatusBox);
            this.SearchBox.Controls.Add(this.Reset);
            this.SearchBox.Controls.Add(this.SearchL);
            this.SearchBox.Controls.Add(this.SearchText);
            this.SearchBox.Controls.Add(this.CriteriesBox);
            this.SearchBox.Controls.Add(this.SearchCriteriaL);
            this.SearchBox.ForeColor = System.Drawing.Color.Snow;
            this.SearchBox.Location = new System.Drawing.Point(281, 7);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(819, 130);
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Поиск";
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.Snow;
            this.StatusBox.Controls.Add(this.IsClosed);
            this.StatusBox.Controls.Add(this.IsRepairs);
            this.StatusBox.Controls.Add(this.IsFramed);
            this.StatusBox.ForeColor = System.Drawing.Color.Black;
            this.StatusBox.Location = new System.Drawing.Point(661, 19);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(142, 99);
            this.StatusBox.TabIndex = 15;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "Фильтр по статусу заказа";
            // 
            // IsClosed
            // 
            this.IsClosed.AutoSize = true;
            this.IsClosed.ForeColor = System.Drawing.Color.Black;
            this.IsClosed.Location = new System.Drawing.Point(6, 65);
            this.IsClosed.Name = "IsClosed";
            this.IsClosed.Size = new System.Drawing.Size(78, 20);
            this.IsClosed.TabIndex = 2;
            this.IsClosed.Text = "Закрыт";
            this.IsClosed.UseVisualStyleBackColor = true;
            this.IsClosed.CheckedChanged += new System.EventHandler(this.IsFramed_CheckedChanged);
            // 
            // IsRepairs
            // 
            this.IsRepairs.AutoSize = true;
            this.IsRepairs.ForeColor = System.Drawing.Color.Black;
            this.IsRepairs.Location = new System.Drawing.Point(6, 41);
            this.IsRepairs.Name = "IsRepairs";
            this.IsRepairs.Size = new System.Drawing.Size(76, 20);
            this.IsRepairs.TabIndex = 1;
            this.IsRepairs.Text = "Ремонт";
            this.IsRepairs.UseVisualStyleBackColor = true;
            this.IsRepairs.CheckedChanged += new System.EventHandler(this.IsFramed_CheckedChanged);
            // 
            // IsFramed
            // 
            this.IsFramed.AutoSize = true;
            this.IsFramed.ForeColor = System.Drawing.Color.Black;
            this.IsFramed.Location = new System.Drawing.Point(6, 19);
            this.IsFramed.Name = "IsFramed";
            this.IsFramed.Size = new System.Drawing.Size(96, 20);
            this.IsFramed.TabIndex = 0;
            this.IsFramed.Text = "Оформлен";
            this.IsFramed.UseVisualStyleBackColor = true;
            this.IsFramed.CheckedChanged += new System.EventHandler(this.IsFramed_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 149);
            this.panel1.TabIndex = 16;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Snow;
            this.MenuBar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вГлавноеМенюToolStripMenuItem,
            this.справочники0ToolStripMenuItem,
            this.оформитьЗаказToolStripMenuItem,
            this.отчетВExcelToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1112, 30);
            this.MenuBar.TabIndex = 17;
            this.MenuBar.Text = "menuStrip1";
            // 
            // вГлавноеМенюToolStripMenuItem
            // 
            this.вГлавноеМенюToolStripMenuItem.Name = "вГлавноеМенюToolStripMenuItem";
            this.вГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.вГлавноеМенюToolStripMenuItem.Text = "В главное меню";
            this.вГлавноеМенюToolStripMenuItem.Click += new System.EventHandler(this.MenuForm_Click);
            // 
            // справочники0ToolStripMenuItem
            // 
            this.справочники0ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.специалистыToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.справочники0ToolStripMenuItem.Name = "справочники0ToolStripMenuItem";
            this.справочники0ToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.справочники0ToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // специалистыToolStripMenuItem
            // 
            this.специалистыToolStripMenuItem.Name = "специалистыToolStripMenuItem";
            this.специалистыToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.специалистыToolStripMenuItem.Text = "Специалисты";
            this.специалистыToolStripMenuItem.Click += new System.EventHandler(this.специалистыToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // оформитьЗаказToolStripMenuItem
            // 
            this.оформитьЗаказToolStripMenuItem.Name = "оформитьЗаказToolStripMenuItem";
            this.оформитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.оформитьЗаказToolStripMenuItem.Text = "Оформить заказ";
            this.оформитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // отчетВExcelToolStripMenuItem
            // 
            this.отчетВExcelToolStripMenuItem.Name = "отчетВExcelToolStripMenuItem";
            this.отчетВExcelToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.отчетВExcelToolStripMenuItem.Text = "Отчет в Excel";
            this.отчетВExcelToolStripMenuItem.Click += new System.EventHandler(this.Create_ExcelReport);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OrdersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1112, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Cambria", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdersForms";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label SearchCriteriaL;
        private System.Windows.Forms.ComboBox CriteriesBox;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem вГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочники0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox StatusBox;
        private System.Windows.Forms.CheckBox IsClosed;
        private System.Windows.Forms.CheckBox IsRepairs;
        private System.Windows.Forms.CheckBox IsFramed;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специалистыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
    }
}