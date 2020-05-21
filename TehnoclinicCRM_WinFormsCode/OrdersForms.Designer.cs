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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusBox = new System.Windows.Forms.GroupBox();
            this.IsClosed = new System.Windows.Forms.RadioButton();
            this.IsRepairs = new System.Windows.Forms.RadioButton();
            this.IsFramed = new System.Windows.Forms.RadioButton();
            this.DateEndSearch = new System.Windows.Forms.TextBox();
            this.SumSearchL = new System.Windows.Forms.Label();
            this.ResetMulty = new System.Windows.Forms.Button();
            this.SumSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SingleBox = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.SingleBox.SuspendLayout();
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
            this.OrdersGrid.Location = new System.Drawing.Point(0, 24);
            this.OrdersGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersGrid.MultiSelect = false;
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGrid.Size = new System.Drawing.Size(1150, 372);
            this.OrdersGrid.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Snow;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(12, 29);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(245, 150);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SearchCriteriaL
            // 
            this.SearchCriteriaL.AutoSize = true;
            this.SearchCriteriaL.Location = new System.Drawing.Point(6, 31);
            this.SearchCriteriaL.Name = "SearchCriteriaL";
            this.SearchCriteriaL.Size = new System.Drawing.Size(89, 12);
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
            this.CriteriesBox.Location = new System.Drawing.Point(151, 28);
            this.CriteriesBox.Name = "CriteriesBox";
            this.CriteriesBox.Size = new System.Drawing.Size(161, 20);
            this.CriteriesBox.TabIndex = 8;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(151, 55);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(161, 20);
            this.SearchText.TabIndex = 9;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Location = new System.Drawing.Point(6, 58);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(71, 12);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Строка ввода";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(8, 91);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(304, 34);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.groupBox1);
            this.SearchBox.Controls.Add(this.SingleBox);
            this.SearchBox.ForeColor = System.Drawing.Color.Snow;
            this.SearchBox.Location = new System.Drawing.Point(281, 7);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(856, 188);
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Поиск";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusBox);
            this.groupBox1.Controls.Add(this.DateEndSearch);
            this.groupBox1.Controls.Add(this.SumSearchL);
            this.groupBox1.Controls.Add(this.ResetMulty);
            this.groupBox1.Controls.Add(this.SumSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(338, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 151);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Множественная фильтрация";
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.StatusBox.Controls.Add(this.IsClosed);
            this.StatusBox.Controls.Add(this.IsRepairs);
            this.StatusBox.Controls.Add(this.IsFramed);
            this.StatusBox.ForeColor = System.Drawing.Color.Snow;
            this.StatusBox.Location = new System.Drawing.Point(12, 19);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(170, 107);
            this.StatusBox.TabIndex = 15;
            this.StatusBox.TabStop = false;
            this.StatusBox.Text = "Фильтр по статусу заказа";
            // 
            // IsClosed
            // 
            this.IsClosed.AutoSize = true;
            this.IsClosed.Location = new System.Drawing.Point(15, 75);
            this.IsClosed.Name = "IsClosed";
            this.IsClosed.Size = new System.Drawing.Size(60, 16);
            this.IsClosed.TabIndex = 5;
            this.IsClosed.TabStop = true;
            this.IsClosed.Text = "Закрыт";
            this.IsClosed.UseVisualStyleBackColor = true;
            this.IsClosed.CheckedChanged += new System.EventHandler(this.IsFramed_CheckedChanged);
            // 
            // IsRepairs
            // 
            this.IsRepairs.AutoSize = true;
            this.IsRepairs.Location = new System.Drawing.Point(15, 49);
            this.IsRepairs.Name = "IsRepairs";
            this.IsRepairs.Size = new System.Drawing.Size(59, 16);
            this.IsRepairs.TabIndex = 4;
            this.IsRepairs.TabStop = true;
            this.IsRepairs.Text = "Ремонт";
            this.IsRepairs.UseVisualStyleBackColor = true;
            this.IsRepairs.CheckedChanged += new System.EventHandler(this.IsFramed_CheckedChanged);
            // 
            // IsFramed
            // 
            this.IsFramed.AutoSize = true;
            this.IsFramed.Location = new System.Drawing.Point(15, 23);
            this.IsFramed.Name = "IsFramed";
            this.IsFramed.Size = new System.Drawing.Size(74, 16);
            this.IsFramed.TabIndex = 3;
            this.IsFramed.TabStop = true;
            this.IsFramed.Text = "Оформлен";
            this.IsFramed.UseVisualStyleBackColor = true;
            this.IsFramed.CheckedChanged += new System.EventHandler(this.IsFramed_CheckedChanged);
            // 
            // DateEndSearch
            // 
            this.DateEndSearch.Location = new System.Drawing.Point(378, 61);
            this.DateEndSearch.Name = "DateEndSearch";
            this.DateEndSearch.Size = new System.Drawing.Size(106, 20);
            this.DateEndSearch.TabIndex = 22;
            this.DateEndSearch.TextChanged += new System.EventHandler(this.DateEndSearch_TextChanged);
            // 
            // SumSearchL
            // 
            this.SumSearchL.AutoSize = true;
            this.SumSearchL.Location = new System.Drawing.Point(220, 29);
            this.SumSearchL.Name = "SumSearchL";
            this.SumSearchL.Size = new System.Drawing.Size(85, 12);
            this.SumSearchL.TabIndex = 17;
            this.SumSearchL.Text = "Итоговая сумма";
            // 
            // ResetMulty
            // 
            this.ResetMulty.BackColor = System.Drawing.Color.Snow;
            this.ResetMulty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetMulty.ForeColor = System.Drawing.Color.Black;
            this.ResetMulty.Location = new System.Drawing.Point(222, 92);
            this.ResetMulty.Name = "ResetMulty";
            this.ResetMulty.Size = new System.Drawing.Size(262, 34);
            this.ResetMulty.TabIndex = 21;
            this.ResetMulty.Text = "Сброс множественной фильтрации";
            this.ResetMulty.UseVisualStyleBackColor = false;
            this.ResetMulty.Click += new System.EventHandler(this.ResetMulty_Click);
            // 
            // SumSearch
            // 
            this.SumSearch.Location = new System.Drawing.Point(378, 26);
            this.SumSearch.Name = "SumSearch";
            this.SumSearch.Size = new System.Drawing.Size(106, 20);
            this.SumSearch.TabIndex = 18;
            this.SumSearch.TextChanged += new System.EventHandler(this.SumSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Дата окончания выполнения";
            // 
            // SingleBox
            // 
            this.SingleBox.Controls.Add(this.SearchCriteriaL);
            this.SingleBox.Controls.Add(this.CriteriesBox);
            this.SingleBox.Controls.Add(this.Reset);
            this.SingleBox.Controls.Add(this.SearchText);
            this.SingleBox.Controls.Add(this.SearchL);
            this.SingleBox.ForeColor = System.Drawing.Color.Snow;
            this.SingleBox.Location = new System.Drawing.Point(6, 22);
            this.SingleBox.Name = "SingleBox";
            this.SingleBox.Size = new System.Drawing.Size(326, 150);
            this.SingleBox.TabIndex = 16;
            this.SingleBox.TabStop = false;
            this.SingleBox.Text = "Одиночная фильтрация";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 207);
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
            this.MenuBar.Size = new System.Drawing.Size(1150, 24);
            this.MenuBar.TabIndex = 17;
            this.MenuBar.Text = "menuStrip1";
            // 
            // вГлавноеМенюToolStripMenuItem
            // 
            this.вГлавноеМенюToolStripMenuItem.Name = "вГлавноеМенюToolStripMenuItem";
            this.вГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
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
            this.справочники0ToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.справочники0ToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // специалистыToolStripMenuItem
            // 
            this.специалистыToolStripMenuItem.Name = "специалистыToolStripMenuItem";
            this.специалистыToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.специалистыToolStripMenuItem.Text = "Специалисты";
            this.специалистыToolStripMenuItem.Click += new System.EventHandler(this.специалистыToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // оформитьЗаказToolStripMenuItem
            // 
            this.оформитьЗаказToolStripMenuItem.Name = "оформитьЗаказToolStripMenuItem";
            this.оформитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.оформитьЗаказToolStripMenuItem.Text = "Оформить заказ";
            this.оформитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // отчетВExcelToolStripMenuItem
            // 
            this.отчетВExcelToolStripMenuItem.Name = "отчетВExcelToolStripMenuItem";
            this.отчетВExcelToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.отчетВExcelToolStripMenuItem.Text = "Отчет в Excel";
            this.отчетВExcelToolStripMenuItem.Click += new System.EventHandler(this.Create_ExcelReport);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OrdersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1150, 603);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Cambria", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdersForms";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.SingleBox.ResumeLayout(false);
            this.SingleBox.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специалистыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.GroupBox SingleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumSearch;
        private System.Windows.Forms.Label SumSearchL;
        private System.Windows.Forms.Button ResetMulty;
        private System.Windows.Forms.RadioButton IsClosed;
        private System.Windows.Forms.RadioButton IsRepairs;
        private System.Windows.Forms.RadioButton IsFramed;
        private System.Windows.Forms.TextBox DateEndSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}