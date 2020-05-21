namespace TehnoclinicCRM_WinFormsCode
{
    partial class SpecialistsReportForm
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
            this.SpecialistGrid = new System.Windows.Forms.DataGridView();
            this.NavigatorPanel = new System.Windows.Forms.Panel();
            this.Print = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ChoosedFieldsBox = new System.Windows.Forms.GroupBox();
            this.NumberPhoneCB = new System.Windows.Forms.CheckBox();
            this.PositionCB = new System.Windows.Forms.CheckBox();
            this.FIOCB = new System.Windows.Forms.CheckBox();
            this.FilterBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.PositionEdit = new System.Windows.Forms.TextBox();
            this.SpecialistEdit = new System.Windows.Forms.TextBox();
            this.PhoneNumberEditL = new System.Windows.Forms.Label();
            this.PositionEditL = new System.Windows.Forms.Label();
            this.SpecialistEditL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistGrid)).BeginInit();
            this.NavigatorPanel.SuspendLayout();
            this.ChoosedFieldsBox.SuspendLayout();
            this.FilterBox.SuspendLayout();
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
            this.SpecialistGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecialistGrid.Location = new System.Drawing.Point(0, 0);
            this.SpecialistGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SpecialistGrid.MultiSelect = false;
            this.SpecialistGrid.Name = "SpecialistGrid";
            this.SpecialistGrid.ReadOnly = true;
            this.SpecialistGrid.RowHeadersWidth = 51;
            this.SpecialistGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecialistGrid.Size = new System.Drawing.Size(724, 523);
            this.SpecialistGrid.TabIndex = 8;
            // 
            // NavigatorPanel
            // 
            this.NavigatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.NavigatorPanel.Controls.Add(this.Print);
            this.NavigatorPanel.Controls.Add(this.Reset);
            this.NavigatorPanel.Controls.Add(this.ChoosedFieldsBox);
            this.NavigatorPanel.Controls.Add(this.FilterBox);
            this.NavigatorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.NavigatorPanel.Location = new System.Drawing.Point(724, 0);
            this.NavigatorPanel.Name = "NavigatorPanel";
            this.NavigatorPanel.Size = new System.Drawing.Size(471, 523);
            this.NavigatorPanel.TabIndex = 7;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Snow;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Print.ForeColor = System.Drawing.Color.Black;
            this.Print.Location = new System.Drawing.Point(9, 462);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(446, 40);
            this.Print.TabIndex = 16;
            this.Print.Text = "Печать";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(9, 417);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(446, 39);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ChoosedFieldsBox
            // 
            this.ChoosedFieldsBox.Controls.Add(this.NumberPhoneCB);
            this.ChoosedFieldsBox.Controls.Add(this.PositionCB);
            this.ChoosedFieldsBox.Controls.Add(this.FIOCB);
            this.ChoosedFieldsBox.ForeColor = System.Drawing.Color.Snow;
            this.ChoosedFieldsBox.Location = new System.Drawing.Point(9, 15);
            this.ChoosedFieldsBox.Name = "ChoosedFieldsBox";
            this.ChoosedFieldsBox.Size = new System.Drawing.Size(446, 152);
            this.ChoosedFieldsBox.TabIndex = 12;
            this.ChoosedFieldsBox.TabStop = false;
            this.ChoosedFieldsBox.Text = "Выбранные поля";
            // 
            // NumberPhoneCB
            // 
            this.NumberPhoneCB.AutoSize = true;
            this.NumberPhoneCB.Checked = true;
            this.NumberPhoneCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumberPhoneCB.Location = new System.Drawing.Point(26, 113);
            this.NumberPhoneCB.Name = "NumberPhoneCB";
            this.NumberPhoneCB.Size = new System.Drawing.Size(81, 20);
            this.NumberPhoneCB.TabIndex = 2;
            this.NumberPhoneCB.Text = "Телефон";
            this.NumberPhoneCB.UseVisualStyleBackColor = true;
            this.NumberPhoneCB.CheckedChanged += new System.EventHandler(this.FIOCB_CheckedChanged);
            // 
            // PositionCB
            // 
            this.PositionCB.AutoSize = true;
            this.PositionCB.Checked = true;
            this.PositionCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PositionCB.Location = new System.Drawing.Point(25, 75);
            this.PositionCB.Name = "PositionCB";
            this.PositionCB.Size = new System.Drawing.Size(96, 20);
            this.PositionCB.TabIndex = 1;
            this.PositionCB.Text = "Должность";
            this.PositionCB.UseVisualStyleBackColor = true;
            this.PositionCB.CheckedChanged += new System.EventHandler(this.FIOCB_CheckedChanged);
            // 
            // FIOCB
            // 
            this.FIOCB.AutoSize = true;
            this.FIOCB.Checked = true;
            this.FIOCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FIOCB.Location = new System.Drawing.Point(26, 39);
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
            this.FilterBox.Controls.Add(this.PositionEdit);
            this.FilterBox.Controls.Add(this.SpecialistEdit);
            this.FilterBox.Controls.Add(this.PhoneNumberEditL);
            this.FilterBox.Controls.Add(this.PositionEditL);
            this.FilterBox.Controls.Add(this.SpecialistEditL);
            this.FilterBox.ForeColor = System.Drawing.Color.Snow;
            this.FilterBox.Location = new System.Drawing.Point(9, 173);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(446, 227);
            this.FilterBox.TabIndex = 8;
            this.FilterBox.TabStop = false;
            this.FilterBox.Text = "Фильтр";
            // 
            // PhoneNumberEdit
            // 
            this.PhoneNumberEdit.Location = new System.Drawing.Point(166, 150);
            this.PhoneNumberEdit.Name = "PhoneNumberEdit";
            this.PhoneNumberEdit.Size = new System.Drawing.Size(252, 23);
            this.PhoneNumberEdit.TabIndex = 11;
            this.PhoneNumberEdit.TextChanged += new System.EventHandler(this.PassportEdit_TextChanged);
            // 
            // PositionEdit
            // 
            this.PositionEdit.Location = new System.Drawing.Point(166, 99);
            this.PositionEdit.Name = "PositionEdit";
            this.PositionEdit.Size = new System.Drawing.Size(252, 23);
            this.PositionEdit.TabIndex = 10;
            this.PositionEdit.TextChanged += new System.EventHandler(this.PassportEdit_TextChanged);
            // 
            // SpecialistEdit
            // 
            this.SpecialistEdit.Location = new System.Drawing.Point(166, 49);
            this.SpecialistEdit.Name = "SpecialistEdit";
            this.SpecialistEdit.Size = new System.Drawing.Size(252, 23);
            this.SpecialistEdit.TabIndex = 8;
            this.SpecialistEdit.TextChanged += new System.EventHandler(this.PassportEdit_TextChanged);
            // 
            // PhoneNumberEditL
            // 
            this.PhoneNumberEditL.AutoSize = true;
            this.PhoneNumberEditL.Location = new System.Drawing.Point(22, 154);
            this.PhoneNumberEditL.Name = "PhoneNumberEditL";
            this.PhoneNumberEditL.Size = new System.Drawing.Size(62, 16);
            this.PhoneNumberEditL.TabIndex = 9;
            this.PhoneNumberEditL.Text = "Телефон";
            // 
            // PositionEditL
            // 
            this.PositionEditL.AutoSize = true;
            this.PositionEditL.Location = new System.Drawing.Point(22, 103);
            this.PositionEditL.Name = "PositionEditL";
            this.PositionEditL.Size = new System.Drawing.Size(77, 16);
            this.PositionEditL.TabIndex = 7;
            this.PositionEditL.Text = "Должность";
            // 
            // SpecialistEditL
            // 
            this.SpecialistEditL.AutoSize = true;
            this.SpecialistEditL.Location = new System.Drawing.Point(22, 53);
            this.SpecialistEditL.Name = "SpecialistEditL";
            this.SpecialistEditL.Size = new System.Drawing.Size(83, 16);
            this.SpecialistEditL.TabIndex = 6;
            this.SpecialistEditL.Text = "Специалист";
            // 
            // SpecialistsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 523);
            this.Controls.Add(this.SpecialistGrid);
            this.Controls.Add(this.NavigatorPanel);
            this.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpecialistsReportForm";
            this.Text = "Отчет специалистов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistGrid)).EndInit();
            this.NavigatorPanel.ResumeLayout(false);
            this.ChoosedFieldsBox.ResumeLayout(false);
            this.ChoosedFieldsBox.PerformLayout();
            this.FilterBox.ResumeLayout(false);
            this.FilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SpecialistGrid;
        private System.Windows.Forms.Panel NavigatorPanel;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.GroupBox ChoosedFieldsBox;
        private System.Windows.Forms.CheckBox NumberPhoneCB;
        private System.Windows.Forms.CheckBox PositionCB;
        private System.Windows.Forms.CheckBox FIOCB;
        private System.Windows.Forms.GroupBox FilterBox;
        private System.Windows.Forms.TextBox PhoneNumberEdit;
        private System.Windows.Forms.TextBox PositionEdit;
        private System.Windows.Forms.TextBox SpecialistEdit;
        private System.Windows.Forms.Label PhoneNumberEditL;
        private System.Windows.Forms.Label PositionEditL;
        private System.Windows.Forms.Label SpecialistEditL;
    }
}