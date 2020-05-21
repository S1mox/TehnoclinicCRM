namespace TehnoclinicCRM_WinFormsCode
{
    partial class ClientsReportForm
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
            this.NavigatorPanel = new System.Windows.Forms.Panel();
            this.Print = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ChoosedFieldsBox = new System.Windows.Forms.GroupBox();
            this.NumberPhoneCB = new System.Windows.Forms.CheckBox();
            this.PassportCB = new System.Windows.Forms.CheckBox();
            this.FIOCB = new System.Windows.Forms.CheckBox();
            this.FilterBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.PassportEdit = new System.Windows.Forms.TextBox();
            this.ClientEdit = new System.Windows.Forms.TextBox();
            this.PhoneNumberEditL = new System.Windows.Forms.Label();
            this.PassportEditL = new System.Windows.Forms.Label();
            this.ClientEditL = new System.Windows.Forms.Label();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.NavigatorPanel.SuspendLayout();
            this.ChoosedFieldsBox.SuspendLayout();
            this.FilterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigatorPanel
            // 
            this.NavigatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.NavigatorPanel.Controls.Add(this.Print);
            this.NavigatorPanel.Controls.Add(this.Reset);
            this.NavigatorPanel.Controls.Add(this.ChoosedFieldsBox);
            this.NavigatorPanel.Controls.Add(this.FilterBox);
            this.NavigatorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.NavigatorPanel.Location = new System.Drawing.Point(693, 0);
            this.NavigatorPanel.Name = "NavigatorPanel";
            this.NavigatorPanel.Size = new System.Drawing.Size(353, 490);
            this.NavigatorPanel.TabIndex = 0;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Snow;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Print.ForeColor = System.Drawing.Color.Black;
            this.Print.Location = new System.Drawing.Point(7, 444);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(334, 40);
            this.Print.TabIndex = 16;
            this.Print.Text = "Печать";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(7, 395);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(334, 43);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ChoosedFieldsBox
            // 
            this.ChoosedFieldsBox.Controls.Add(this.NumberPhoneCB);
            this.ChoosedFieldsBox.Controls.Add(this.PassportCB);
            this.ChoosedFieldsBox.Controls.Add(this.FIOCB);
            this.ChoosedFieldsBox.ForeColor = System.Drawing.Color.Snow;
            this.ChoosedFieldsBox.Location = new System.Drawing.Point(7, 12);
            this.ChoosedFieldsBox.Name = "ChoosedFieldsBox";
            this.ChoosedFieldsBox.Size = new System.Drawing.Size(334, 157);
            this.ChoosedFieldsBox.TabIndex = 12;
            this.ChoosedFieldsBox.TabStop = false;
            this.ChoosedFieldsBox.Text = "Выбранные поля";
            // 
            // NumberPhoneCB
            // 
            this.NumberPhoneCB.AutoSize = true;
            this.NumberPhoneCB.Checked = true;
            this.NumberPhoneCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumberPhoneCB.Location = new System.Drawing.Point(20, 114);
            this.NumberPhoneCB.Name = "NumberPhoneCB";
            this.NumberPhoneCB.Size = new System.Drawing.Size(81, 20);
            this.NumberPhoneCB.TabIndex = 2;
            this.NumberPhoneCB.Text = "Телефон";
            this.NumberPhoneCB.UseVisualStyleBackColor = true;
            this.NumberPhoneCB.CheckedChanged += new System.EventHandler(this.FIOCB_CheckedChanged);
            // 
            // PassportCB
            // 
            this.PassportCB.AutoSize = true;
            this.PassportCB.Checked = true;
            this.PassportCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PassportCB.Location = new System.Drawing.Point(20, 71);
            this.PassportCB.Name = "PassportCB";
            this.PassportCB.Size = new System.Drawing.Size(79, 20);
            this.PassportCB.TabIndex = 1;
            this.PassportCB.Text = "Паспорт";
            this.PassportCB.UseVisualStyleBackColor = true;
            this.PassportCB.CheckedChanged += new System.EventHandler(this.FIOCB_CheckedChanged);
            // 
            // FIOCB
            // 
            this.FIOCB.AutoSize = true;
            this.FIOCB.Checked = true;
            this.FIOCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FIOCB.Location = new System.Drawing.Point(20, 32);
            this.FIOCB.Name = "FIOCB";
            this.FIOCB.Size = new System.Drawing.Size(57, 20);
            this.FIOCB.TabIndex = 0;
            this.FIOCB.Text = "ФИО";
            this.FIOCB.UseVisualStyleBackColor = true;
            this.FIOCB.CheckedChanged += new System.EventHandler(this.FIOCB_CheckedChanged);
            // 
            // FilterBox
            // 
            this.FilterBox.Controls.Add(this.PhoneNumberEdit);
            this.FilterBox.Controls.Add(this.PassportEdit);
            this.FilterBox.Controls.Add(this.ClientEdit);
            this.FilterBox.Controls.Add(this.PhoneNumberEditL);
            this.FilterBox.Controls.Add(this.PassportEditL);
            this.FilterBox.Controls.Add(this.ClientEditL);
            this.FilterBox.ForeColor = System.Drawing.Color.Snow;
            this.FilterBox.Location = new System.Drawing.Point(7, 191);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(334, 185);
            this.FilterBox.TabIndex = 8;
            this.FilterBox.TabStop = false;
            this.FilterBox.Text = "Фильтр";
            // 
            // PhoneNumberEdit
            // 
            this.PhoneNumberEdit.Location = new System.Drawing.Point(124, 122);
            this.PhoneNumberEdit.Name = "PhoneNumberEdit";
            this.PhoneNumberEdit.Size = new System.Drawing.Size(190, 23);
            this.PhoneNumberEdit.TabIndex = 11;
            this.PhoneNumberEdit.TextChanged += new System.EventHandler(this.PassportEdit_TextChanged);
            // 
            // PassportEdit
            // 
            this.PassportEdit.Location = new System.Drawing.Point(124, 81);
            this.PassportEdit.Name = "PassportEdit";
            this.PassportEdit.Size = new System.Drawing.Size(190, 23);
            this.PassportEdit.TabIndex = 10;
            this.PassportEdit.TextChanged += new System.EventHandler(this.PassportEdit_TextChanged);
            // 
            // ClientEdit
            // 
            this.ClientEdit.Location = new System.Drawing.Point(124, 40);
            this.ClientEdit.Name = "ClientEdit";
            this.ClientEdit.Size = new System.Drawing.Size(190, 23);
            this.ClientEdit.TabIndex = 8;
            this.ClientEdit.TextChanged += new System.EventHandler(this.PassportEdit_TextChanged);
            // 
            // PhoneNumberEditL
            // 
            this.PhoneNumberEditL.AutoSize = true;
            this.PhoneNumberEditL.Location = new System.Drawing.Point(16, 125);
            this.PhoneNumberEditL.Name = "PhoneNumberEditL";
            this.PhoneNumberEditL.Size = new System.Drawing.Size(62, 16);
            this.PhoneNumberEditL.TabIndex = 9;
            this.PhoneNumberEditL.Text = "Телефон";
            // 
            // PassportEditL
            // 
            this.PassportEditL.AutoSize = true;
            this.PassportEditL.Location = new System.Drawing.Point(16, 84);
            this.PassportEditL.Name = "PassportEditL";
            this.PassportEditL.Size = new System.Drawing.Size(60, 16);
            this.PassportEditL.TabIndex = 7;
            this.PassportEditL.Text = "Паспорт";
            // 
            // ClientEditL
            // 
            this.ClientEditL.AutoSize = true;
            this.ClientEditL.Location = new System.Drawing.Point(16, 43);
            this.ClientEditL.Name = "ClientEditL";
            this.ClientEditL.Size = new System.Drawing.Size(55, 16);
            this.ClientEditL.TabIndex = 6;
            this.ClientEditL.Text = "Клиент";
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AllowUserToAddRows = false;
            this.ClientsGrid.AllowUserToDeleteRows = false;
            this.ClientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ClientsGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsGrid.Location = new System.Drawing.Point(0, 0);
            this.ClientsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsGrid.MultiSelect = false;
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.ReadOnly = true;
            this.ClientsGrid.RowHeadersWidth = 51;
            this.ClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsGrid.Size = new System.Drawing.Size(693, 490);
            this.ClientsGrid.TabIndex = 6;
            // 
            // ClientsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 490);
            this.Controls.Add(this.ClientsGrid);
            this.Controls.Add(this.NavigatorPanel);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientsReportForm";
            this.Text = "ClientsReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.NavigatorPanel.ResumeLayout(false);
            this.ChoosedFieldsBox.ResumeLayout(false);
            this.ChoosedFieldsBox.PerformLayout();
            this.FilterBox.ResumeLayout(false);
            this.FilterBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigatorPanel;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.GroupBox ChoosedFieldsBox;
        private System.Windows.Forms.GroupBox FilterBox;
        private System.Windows.Forms.TextBox PhoneNumberEdit;
        private System.Windows.Forms.TextBox PassportEdit;
        private System.Windows.Forms.TextBox ClientEdit;
        private System.Windows.Forms.Label PhoneNumberEditL;
        private System.Windows.Forms.Label PassportEditL;
        private System.Windows.Forms.Label ClientEditL;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.CheckBox NumberPhoneCB;
        private System.Windows.Forms.CheckBox PassportCB;
        private System.Windows.Forms.CheckBox FIOCB;
    }
}