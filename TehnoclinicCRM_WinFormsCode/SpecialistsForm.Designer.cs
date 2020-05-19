namespace TehnoclinicCRM_WinFormsCode
{
    partial class SpecialistsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialistsForm));
            this.SpecialistGrid = new System.Windows.Forms.DataGridView();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SearchL = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.CriteriesBox = new System.Windows.Forms.ComboBox();
            this.SearchCriteriaL = new System.Windows.Forms.Label();
            this.EditBox = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.PhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.PositionEdit = new System.Windows.Forms.TextBox();
            this.SpecialistEdit = new System.Windows.Forms.TextBox();
            this.PhoneNumberEditL = new System.Windows.Forms.Label();
            this.PositionEditL = new System.Windows.Forms.Label();
            this.SpecialistEditL = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.вГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочники0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.AddBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.PhoneNumberL = new System.Windows.Forms.Label();
            this.PositionL = new System.Windows.Forms.Label();
            this.SpecialistL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistGrid)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.SearchBox.SuspendLayout();
            this.EditBox.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.AddBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpecialistGrid
            // 
            this.SpecialistGrid.AllowUserToAddRows = false;
            this.SpecialistGrid.AllowUserToDeleteRows = false;
            this.SpecialistGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SpecialistGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.SpecialistGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.SpecialistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecialistGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpecialistGrid.Location = new System.Drawing.Point(0, 0);
            this.SpecialistGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SpecialistGrid.MultiSelect = false;
            this.SpecialistGrid.Name = "SpecialistGrid";
            this.SpecialistGrid.ReadOnly = true;
            this.SpecialistGrid.RowHeadersWidth = 51;
            this.SpecialistGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecialistGrid.Size = new System.Drawing.Size(645, 363);
            this.SpecialistGrid.TabIndex = 0;
            this.SpecialistGrid.SelectionChanged += new System.EventHandler(this.Get_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.FooterPanel.Controls.Add(this.Delete);
            this.FooterPanel.Controls.Add(this.SearchBox);
            this.FooterPanel.Controls.Add(this.EditBox);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 387);
            this.FooterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(974, 252);
            this.FooterPanel.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Snow;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(390, 85);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(214, 70);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.Reset);
            this.SearchBox.Controls.Add(this.SearchL);
            this.SearchBox.Controls.Add(this.SearchText);
            this.SearchBox.Controls.Add(this.CriteriesBox);
            this.SearchBox.Controls.Add(this.SearchCriteriaL);
            this.SearchBox.ForeColor = System.Drawing.Color.Snow;
            this.SearchBox.Location = new System.Drawing.Point(628, 15);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(334, 228);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Поиск";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(26, 165);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(284, 47);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Location = new System.Drawing.Point(16, 84);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(85, 15);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Строка ввода";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(161, 81);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(161, 23);
            this.SearchText.TabIndex = 9;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // CriteriesBox
            // 
            this.CriteriesBox.FormattingEnabled = true;
            this.CriteriesBox.Items.AddRange(new object[] {
            "ФИО",
            "Должность",
            "Телефон"});
            this.CriteriesBox.Location = new System.Drawing.Point(161, 40);
            this.CriteriesBox.Name = "CriteriesBox";
            this.CriteriesBox.Size = new System.Drawing.Size(161, 23);
            this.CriteriesBox.TabIndex = 8;
            // 
            // SearchCriteriaL
            // 
            this.SearchCriteriaL.AutoSize = true;
            this.SearchCriteriaL.Location = new System.Drawing.Point(16, 43);
            this.SearchCriteriaL.Name = "SearchCriteriaL";
            this.SearchCriteriaL.Size = new System.Drawing.Size(110, 15);
            this.SearchCriteriaL.TabIndex = 7;
            this.SearchCriteriaL.Text = "Критерий поиска";
            // 
            // EditBox
            // 
            this.EditBox.Controls.Add(this.Save);
            this.EditBox.Controls.Add(this.PhoneNumberEdit);
            this.EditBox.Controls.Add(this.PositionEdit);
            this.EditBox.Controls.Add(this.SpecialistEdit);
            this.EditBox.Controls.Add(this.PhoneNumberEditL);
            this.EditBox.Controls.Add(this.PositionEditL);
            this.EditBox.Controls.Add(this.SpecialistEditL);
            this.EditBox.ForeColor = System.Drawing.Color.Snow;
            this.EditBox.Location = new System.Drawing.Point(12, 15);
            this.EditBox.Name = "EditBox";
            this.EditBox.Size = new System.Drawing.Size(359, 228);
            this.EditBox.TabIndex = 0;
            this.EditBox.TabStop = false;
            this.EditBox.Text = "Редактирование записей";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Snow;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(30, 165);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(294, 47);
            this.Save.TabIndex = 12;
            this.Save.Text = "Сохранить изменения";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Update_Click);
            // 
            // PhoneNumberEdit
            // 
            this.PhoneNumberEdit.Location = new System.Drawing.Point(134, 122);
            this.PhoneNumberEdit.Name = "PhoneNumberEdit";
            this.PhoneNumberEdit.Size = new System.Drawing.Size(190, 23);
            this.PhoneNumberEdit.TabIndex = 11;
            // 
            // PositionEdit
            // 
            this.PositionEdit.Location = new System.Drawing.Point(134, 81);
            this.PositionEdit.Name = "PositionEdit";
            this.PositionEdit.Size = new System.Drawing.Size(190, 23);
            this.PositionEdit.TabIndex = 10;
            // 
            // SpecialistEdit
            // 
            this.SpecialistEdit.Location = new System.Drawing.Point(134, 40);
            this.SpecialistEdit.Name = "SpecialistEdit";
            this.SpecialistEdit.Size = new System.Drawing.Size(190, 23);
            this.SpecialistEdit.TabIndex = 8;
            // 
            // PhoneNumberEditL
            // 
            this.PhoneNumberEditL.AutoSize = true;
            this.PhoneNumberEditL.Location = new System.Drawing.Point(26, 125);
            this.PhoneNumberEditL.Name = "PhoneNumberEditL";
            this.PhoneNumberEditL.Size = new System.Drawing.Size(57, 15);
            this.PhoneNumberEditL.TabIndex = 9;
            this.PhoneNumberEditL.Text = "Телефон";
            // 
            // PositionEditL
            // 
            this.PositionEditL.AutoSize = true;
            this.PositionEditL.Location = new System.Drawing.Point(26, 84);
            this.PositionEditL.Name = "PositionEditL";
            this.PositionEditL.Size = new System.Drawing.Size(74, 15);
            this.PositionEditL.TabIndex = 7;
            this.PositionEditL.Text = "Должность";
            // 
            // SpecialistEditL
            // 
            this.SpecialistEditL.AutoSize = true;
            this.SpecialistEditL.Location = new System.Drawing.Point(26, 43);
            this.SpecialistEditL.Name = "SpecialistEditL";
            this.SpecialistEditL.Size = new System.Drawing.Size(76, 15);
            this.SpecialistEditL.TabIndex = 6;
            this.SpecialistEditL.Text = "Специалист";
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
            this.MenuBar.Size = new System.Drawing.Size(974, 24);
            this.MenuBar.TabIndex = 2;
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
            this.услугиToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.справочники0ToolStripMenuItem.Name = "справочники0ToolStripMenuItem";
            this.справочники0ToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.справочники0ToolStripMenuItem.Text = "Справочники";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
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
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Snow;
            this.HeaderPanel.Controls.Add(this.AddBox);
            this.HeaderPanel.Controls.Add(this.SpecialistGrid);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 24);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(974, 363);
            this.HeaderPanel.TabIndex = 3;
            // 
            // AddBox
            // 
            this.AddBox.Controls.Add(this.PhoneNumber);
            this.AddBox.Controls.Add(this.Position);
            this.AddBox.Controls.Add(this.FIO);
            this.AddBox.Controls.Add(this.Add);
            this.AddBox.Controls.Add(this.PhoneNumberL);
            this.AddBox.Controls.Add(this.PositionL);
            this.AddBox.Controls.Add(this.SpecialistL);
            this.AddBox.Location = new System.Drawing.Point(652, 3);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(310, 353);
            this.AddBox.TabIndex = 1;
            this.AddBox.TabStop = false;
            this.AddBox.Text = "Добавление";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(114, 122);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(190, 23);
            this.PhoneNumber.TabIndex = 5;
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(114, 81);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(190, 23);
            this.Position.TabIndex = 4;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(114, 40);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(190, 23);
            this.FIO.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.ForeColor = System.Drawing.Color.Snow;
            this.Add.Location = new System.Drawing.Point(10, 184);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(294, 121);
            this.Add.TabIndex = 3;
            this.Add.Text = "Сохранить запись в базу";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PhoneNumberL
            // 
            this.PhoneNumberL.AutoSize = true;
            this.PhoneNumberL.Location = new System.Drawing.Point(6, 125);
            this.PhoneNumberL.Name = "PhoneNumberL";
            this.PhoneNumberL.Size = new System.Drawing.Size(57, 15);
            this.PhoneNumberL.TabIndex = 2;
            this.PhoneNumberL.Text = "Телефон";
            // 
            // PositionL
            // 
            this.PositionL.AutoSize = true;
            this.PositionL.Location = new System.Drawing.Point(6, 84);
            this.PositionL.Name = "PositionL";
            this.PositionL.Size = new System.Drawing.Size(74, 15);
            this.PositionL.TabIndex = 1;
            this.PositionL.Text = "Должность";
            // 
            // SpecialistL
            // 
            this.SpecialistL.AutoSize = true;
            this.SpecialistL.Location = new System.Drawing.Point(6, 43);
            this.SpecialistL.Name = "SpecialistL";
            this.SpecialistL.Size = new System.Drawing.Size(76, 15);
            this.SpecialistL.TabIndex = 0;
            this.SpecialistL.Text = "Специалист";
            // 
            // SpecialistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 639);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpecialistsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специалисты";
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistGrid)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.EditBox.ResumeLayout(false);
            this.EditBox.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.AddBox.ResumeLayout(false);
            this.AddBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SpecialistGrid;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.GroupBox EditBox;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem вГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочники0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.GroupBox AddBox;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Position;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label PhoneNumberL;
        private System.Windows.Forms.Label PositionL;
        private System.Windows.Forms.Label SpecialistL;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox PhoneNumberEdit;
        private System.Windows.Forms.TextBox PositionEdit;
        private System.Windows.Forms.TextBox SpecialistEdit;
        private System.Windows.Forms.Label PhoneNumberEditL;
        private System.Windows.Forms.Label PositionEditL;
        private System.Windows.Forms.Label SpecialistEditL;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox CriteriesBox;
        private System.Windows.Forms.Label SearchCriteriaL;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
    }
}