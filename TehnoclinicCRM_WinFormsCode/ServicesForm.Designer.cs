namespace TehnoclinicCRM_WinFormsCode
{
    partial class ServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.вГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkPlace = new System.Windows.Forms.Panel();
            this.ServicesGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SearchL = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.CriteriesBox = new System.Windows.Forms.ComboBox();
            this.SearchCriteriaL = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            this.WorkPlace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Snow;
            this.MenuBar.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вГлавноеМенюToolStripMenuItem,
            this.отчетВExcelToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuBar.Size = new System.Drawing.Size(820, 24);
            this.MenuBar.TabIndex = 4;
            this.MenuBar.Text = "menuStrip1";
            // 
            // вГлавноеМенюToolStripMenuItem
            // 
            this.вГлавноеМенюToolStripMenuItem.Name = "вГлавноеМенюToolStripMenuItem";
            this.вГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.вГлавноеМенюToolStripMenuItem.Text = "В главное меню";
            this.вГлавноеМенюToolStripMenuItem.Click += new System.EventHandler(this.MenuForm_Click);
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
            // WorkPlace
            // 
            this.WorkPlace.Controls.Add(this.ServicesGrid);
            this.WorkPlace.Controls.Add(this.panel1);
            this.WorkPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkPlace.Location = new System.Drawing.Point(0, 24);
            this.WorkPlace.Margin = new System.Windows.Forms.Padding(4);
            this.WorkPlace.Name = "WorkPlace";
            this.WorkPlace.Size = new System.Drawing.Size(820, 493);
            this.WorkPlace.TabIndex = 5;
            // 
            // ServicesGrid
            // 
            this.ServicesGrid.AllowUserToAddRows = false;
            this.ServicesGrid.AllowUserToDeleteRows = false;
            this.ServicesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServicesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ServicesGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.ServicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesGrid.Location = new System.Drawing.Point(0, 0);
            this.ServicesGrid.Margin = new System.Windows.Forms.Padding(5);
            this.ServicesGrid.MultiSelect = false;
            this.ServicesGrid.Name = "ServicesGrid";
            this.ServicesGrid.ReadOnly = true;
            this.ServicesGrid.RowHeadersWidth = 51;
            this.ServicesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesGrid.Size = new System.Drawing.Size(820, 307);
            this.ServicesGrid.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.LogoPic);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 186);
            this.panel1.TabIndex = 0;
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.LogoPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoPic.Enabled = false;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoPic.Location = new System.Drawing.Point(406, 0);
            this.LogoPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Padding = new System.Windows.Forms.Padding(85, 50, 0, 0);
            this.LogoPic.Size = new System.Drawing.Size(414, 186);
            this.LogoPic.TabIndex = 3;
            this.LogoPic.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.Reset);
            this.SearchBox.Controls.Add(this.SearchL);
            this.SearchBox.Controls.Add(this.SearchText);
            this.SearchBox.Controls.Add(this.CriteriesBox);
            this.SearchBox.Controls.Add(this.SearchCriteriaL);
            this.SearchBox.Font = new System.Drawing.Font("Cambria", 12F);
            this.SearchBox.ForeColor = System.Drawing.Color.Snow;
            this.SearchBox.Location = new System.Drawing.Point(12, 11);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(387, 163);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Поиск";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(116, 119);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(159, 33);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Location = new System.Drawing.Point(16, 74);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(107, 19);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Строка ввода";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(202, 71);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(161, 26);
            this.SearchText.TabIndex = 9;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // CriteriesBox
            // 
            this.CriteriesBox.FormattingEnabled = true;
            this.CriteriesBox.Items.AddRange(new object[] {
            "Подразделение",
            "Услуга",
            "Цена"});
            this.CriteriesBox.Location = new System.Drawing.Point(202, 27);
            this.CriteriesBox.Name = "CriteriesBox";
            this.CriteriesBox.Size = new System.Drawing.Size(161, 27);
            this.CriteriesBox.TabIndex = 8;
            // 
            // SearchCriteriaL
            // 
            this.SearchCriteriaL.AutoSize = true;
            this.SearchCriteriaL.Location = new System.Drawing.Point(16, 30);
            this.SearchCriteriaL.Name = "SearchCriteriaL";
            this.SearchCriteriaL.Size = new System.Drawing.Size(135, 19);
            this.SearchCriteriaL.TabIndex = 7;
            this.SearchCriteriaL.Text = "Критерий поиска";
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(820, 517);
            this.Controls.Add(this.WorkPlace);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Cambria", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServicesForm";
            this.Text = "Услуги";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.WorkPlace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem вГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel WorkPlace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ServicesGrid;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox CriteriesBox;
        private System.Windows.Forms.Label SearchCriteriaL;
        private System.Windows.Forms.PictureBox LogoPic;
    }
}