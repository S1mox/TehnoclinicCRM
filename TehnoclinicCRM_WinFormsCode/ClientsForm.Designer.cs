namespace TehnoclinicCRM_WinFormsCode
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.вГлавноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочники0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SearchL = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.CriteriesBox = new System.Windows.Forms.ComboBox();
            this.SearchCriteriaL = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.EditBox = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.PhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.PassportEdit = new System.Windows.Forms.TextBox();
            this.ClientEdit = new System.Windows.Forms.TextBox();
            this.PhoneNumberEditL = new System.Windows.Forms.Label();
            this.PassportEditL = new System.Windows.Forms.Label();
            this.ClientEditL = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Passport = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.PhoneNumberL = new System.Windows.Forms.Label();
            this.PassportL = new System.Windows.Forms.Label();
            this.ClientL = new System.Windows.Forms.Label();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.MenuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchBox.SuspendLayout();
            this.EditBox.SuspendLayout();
            this.AddBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.SuspendLayout();
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
            this.MenuBar.Size = new System.Drawing.Size(1066, 28);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "menuStrip1";
            // 
            // вГлавноеМенюToolStripMenuItem
            // 
            this.вГлавноеМенюToolStripMenuItem.Name = "вГлавноеМенюToolStripMenuItem";
            this.вГлавноеМенюToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.вГлавноеМенюToolStripMenuItem.Text = "В главное меню";
            // 
            // справочники0ToolStripMenuItem
            // 
            this.справочники0ToolStripMenuItem.Name = "справочники0ToolStripMenuItem";
            this.справочники0ToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.справочники0ToolStripMenuItem.Text = "Справочники";
            this.справочники0ToolStripMenuItem.Click += new System.EventHandler(this.Dictionary_Click);
            // 
            // оформитьЗаказToolStripMenuItem
            // 
            this.оформитьЗаказToolStripMenuItem.Name = "оформитьЗаказToolStripMenuItem";
            this.оформитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.оформитьЗаказToolStripMenuItem.Text = "Оформить заказ";
            // 
            // отчетВExcelToolStripMenuItem
            // 
            this.отчетВExcelToolStripMenuItem.Name = "отчетВExcelToolStripMenuItem";
            this.отчетВExcelToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.отчетВExcelToolStripMenuItem.Text = "Отчет в Excel";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.EditBox);
            this.panel1.Controls.Add(this.AddBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 261);
            this.panel1.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.Reset);
            this.SearchBox.Controls.Add(this.SearchL);
            this.SearchBox.Controls.Add(this.SearchText);
            this.SearchBox.Controls.Add(this.CriteriesBox);
            this.SearchBox.Controls.Add(this.SearchCriteriaL);
            this.SearchBox.ForeColor = System.Drawing.Color.Snow;
            this.SearchBox.Location = new System.Drawing.Point(728, 76);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(326, 172);
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Поиск";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(45, 109);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(242, 47);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Location = new System.Drawing.Point(6, 69);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(111, 20);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Строка ввода";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(186, 66);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(130, 27);
            this.SearchText.TabIndex = 9;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // CriteriesBox
            // 
            this.CriteriesBox.FormattingEnabled = true;
            this.CriteriesBox.Items.AddRange(new object[] {
            "ФИО",
            "Паспорт",
            "Номер телефона"});
            this.CriteriesBox.Location = new System.Drawing.Point(186, 28);
            this.CriteriesBox.Name = "CriteriesBox";
            this.CriteriesBox.Size = new System.Drawing.Size(130, 27);
            this.CriteriesBox.TabIndex = 8;
            // 
            // SearchCriteriaL
            // 
            this.SearchCriteriaL.AutoSize = true;
            this.SearchCriteriaL.Location = new System.Drawing.Point(5, 31);
            this.SearchCriteriaL.Name = "SearchCriteriaL";
            this.SearchCriteriaL.Size = new System.Drawing.Size(143, 20);
            this.SearchCriteriaL.TabIndex = 7;
            this.SearchCriteriaL.Text = "Критерий поиска";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Snow;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(728, 14);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(326, 56);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EditBox
            // 
            this.EditBox.Controls.Add(this.Save);
            this.EditBox.Controls.Add(this.PhoneNumberEdit);
            this.EditBox.Controls.Add(this.PassportEdit);
            this.EditBox.Controls.Add(this.ClientEdit);
            this.EditBox.Controls.Add(this.PhoneNumberEditL);
            this.EditBox.Controls.Add(this.PassportEditL);
            this.EditBox.Controls.Add(this.ClientEditL);
            this.EditBox.ForeColor = System.Drawing.Color.Snow;
            this.EditBox.Location = new System.Drawing.Point(377, 7);
            this.EditBox.Name = "EditBox";
            this.EditBox.Size = new System.Drawing.Size(334, 241);
            this.EditBox.TabIndex = 7;
            this.EditBox.TabStop = false;
            this.EditBox.Text = "Редактирование записей";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Snow;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(19, 175);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(294, 47);
            this.Save.TabIndex = 12;
            this.Save.Text = "Сохранить изменения";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Update_Click);
            // 
            // PhoneNumberEdit
            // 
            this.PhoneNumberEdit.Location = new System.Drawing.Point(124, 122);
            this.PhoneNumberEdit.Name = "PhoneNumberEdit";
            this.PhoneNumberEdit.Size = new System.Drawing.Size(190, 27);
            this.PhoneNumberEdit.TabIndex = 11;
            // 
            // PassportEdit
            // 
            this.PassportEdit.Location = new System.Drawing.Point(124, 81);
            this.PassportEdit.Name = "PassportEdit";
            this.PassportEdit.Size = new System.Drawing.Size(190, 27);
            this.PassportEdit.TabIndex = 10;
            // 
            // ClientEdit
            // 
            this.ClientEdit.Location = new System.Drawing.Point(124, 40);
            this.ClientEdit.Name = "ClientEdit";
            this.ClientEdit.Size = new System.Drawing.Size(190, 27);
            this.ClientEdit.TabIndex = 8;
            // 
            // PhoneNumberEditL
            // 
            this.PhoneNumberEditL.AutoSize = true;
            this.PhoneNumberEditL.Location = new System.Drawing.Point(16, 125);
            this.PhoneNumberEditL.Name = "PhoneNumberEditL";
            this.PhoneNumberEditL.Size = new System.Drawing.Size(75, 20);
            this.PhoneNumberEditL.TabIndex = 9;
            this.PhoneNumberEditL.Text = "Телефон";
            // 
            // PassportEditL
            // 
            this.PassportEditL.AutoSize = true;
            this.PassportEditL.Location = new System.Drawing.Point(16, 84);
            this.PassportEditL.Name = "PassportEditL";
            this.PassportEditL.Size = new System.Drawing.Size(73, 20);
            this.PassportEditL.TabIndex = 7;
            this.PassportEditL.Text = "Паспорт";
            // 
            // ClientEditL
            // 
            this.ClientEditL.AutoSize = true;
            this.ClientEditL.Location = new System.Drawing.Point(16, 43);
            this.ClientEditL.Name = "ClientEditL";
            this.ClientEditL.Size = new System.Drawing.Size(67, 20);
            this.ClientEditL.TabIndex = 6;
            this.ClientEditL.Text = "Клиент";
            // 
            // AddBox
            // 
            this.AddBox.Controls.Add(this.PhoneNumber);
            this.AddBox.Controls.Add(this.Passport);
            this.AddBox.Controls.Add(this.FIO);
            this.AddBox.Controls.Add(this.Add);
            this.AddBox.Controls.Add(this.PhoneNumberL);
            this.AddBox.Controls.Add(this.PassportL);
            this.AddBox.Controls.Add(this.ClientL);
            this.AddBox.ForeColor = System.Drawing.Color.Snow;
            this.AddBox.Location = new System.Drawing.Point(12, 7);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(348, 241);
            this.AddBox.TabIndex = 6;
            this.AddBox.TabStop = false;
            this.AddBox.Text = "Добавление";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(149, 122);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(190, 27);
            this.PhoneNumber.TabIndex = 5;
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(149, 81);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(190, 27);
            this.Passport.TabIndex = 4;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(149, 40);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(190, 27);
            this.FIO.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Snow;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(27, 171);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(294, 54);
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
            this.PhoneNumberL.Size = new System.Drawing.Size(136, 20);
            this.PhoneNumberL.TabIndex = 2;
            this.PhoneNumberL.Text = "Номер телефона";
            // 
            // PassportL
            // 
            this.PassportL.AutoSize = true;
            this.PassportL.Location = new System.Drawing.Point(6, 84);
            this.PassportL.Name = "PassportL";
            this.PassportL.Size = new System.Drawing.Size(73, 20);
            this.PassportL.TabIndex = 1;
            this.PassportL.Text = "Паспорт";
            // 
            // ClientL
            // 
            this.ClientL.AutoSize = true;
            this.ClientL.Location = new System.Drawing.Point(6, 43);
            this.ClientL.Name = "ClientL";
            this.ClientL.Size = new System.Drawing.Size(67, 20);
            this.ClientL.TabIndex = 0;
            this.ClientL.Text = "Клиент";
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AllowUserToAddRows = false;
            this.ClientsGrid.AllowUserToDeleteRows = false;
            this.ClientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ClientsGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientsGrid.Location = new System.Drawing.Point(0, 28);
            this.ClientsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsGrid.MultiSelect = false;
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.ReadOnly = true;
            this.ClientsGrid.RowHeadersWidth = 51;
            this.ClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsGrid.Size = new System.Drawing.Size(1066, 398);
            this.ClientsGrid.TabIndex = 5;
            this.ClientsGrid.SelectionChanged += new System.EventHandler(this.Get_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 687);
            this.Controls.Add(this.ClientsGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsForm";
            this.Text = "Клиенты";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.EditBox.ResumeLayout(false);
            this.EditBox.PerformLayout();
            this.AddBox.ResumeLayout(false);
            this.AddBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem вГлавноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочники0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.GroupBox AddBox;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label PhoneNumberL;
        private System.Windows.Forms.Label PassportL;
        private System.Windows.Forms.Label ClientL;
        private System.Windows.Forms.GroupBox EditBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox PhoneNumberEdit;
        private System.Windows.Forms.TextBox PassportEdit;
        private System.Windows.Forms.TextBox ClientEdit;
        private System.Windows.Forms.Label PhoneNumberEditL;
        private System.Windows.Forms.Label PassportEditL;
        private System.Windows.Forms.Label ClientEditL;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox CriteriesBox;
        private System.Windows.Forms.Label SearchCriteriaL;
    }
}