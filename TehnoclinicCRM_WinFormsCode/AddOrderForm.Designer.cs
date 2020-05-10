namespace TehnoclinicCRM_WinFormsCode
{
    partial class AddOrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            this.DataOfReceivingEditL = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.CurrentTime = new System.Windows.Forms.DateTimePicker();
            this.ClientBox = new System.Windows.Forms.GroupBox();
            this.Clients = new System.Windows.Forms.Button();
            this.ClientL = new System.Windows.Forms.Label();
            this.ClientsBox = new System.Windows.Forms.ComboBox();
            this.SpecialistBox = new System.Windows.Forms.GroupBox();
            this.Specialsits = new System.Windows.Forms.Button();
            this.SpecialistL = new System.Windows.Forms.Label();
            this.SpecialistsBox = new System.Windows.Forms.ComboBox();
            this.ServiceBox = new System.Windows.Forms.GroupBox();
            this.MoreBox = new System.Windows.Forms.GroupBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.DateOfReceiveDP = new System.Windows.Forms.DateTimePicker();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.CurrentTimeTicker = new System.Windows.Forms.Timer(this.components);
            this.DateOfBeginL = new System.Windows.Forms.Label();
            this.DateOfEndL = new System.Windows.Forms.Label();
            this.SumL = new System.Windows.Forms.Label();
            this.StatusL = new System.Windows.Forms.Label();
            this.DateOfEndEdit = new System.Windows.Forms.DateTimePicker();
            this.DateOfBeginEdit = new System.Windows.Forms.DateTimePicker();
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.StatusEdit = new System.Windows.Forms.ComboBox();
            this.FooterPanel.SuspendLayout();
            this.ClientBox.SuspendLayout();
            this.SpecialistBox.SuspendLayout();
            this.MoreBox.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DataOfReceivingEditL
            // 
            this.DataOfReceivingEditL.AutoSize = true;
            this.DataOfReceivingEditL.ForeColor = System.Drawing.Color.Snow;
            this.DataOfReceivingEditL.Location = new System.Drawing.Point(12, 25);
            this.DataOfReceivingEditL.Name = "DataOfReceivingEditL";
            this.DataOfReceivingEditL.Size = new System.Drawing.Size(151, 20);
            this.DataOfReceivingEditL.TabIndex = 7;
            this.DataOfReceivingEditL.Text = "Дата поступления";
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.Snow;
            this.FooterPanel.Controls.Add(this.Reset);
            this.FooterPanel.Controls.Add(this.Add);
            this.FooterPanel.Controls.Add(this.CurrentTime);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 576);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(971, 57);
            this.FooterPanel.TabIndex = 8;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Snow;
            this.Reset.Location = new System.Drawing.Point(544, 11);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(169, 32);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.ForeColor = System.Drawing.Color.Snow;
            this.Add.Location = new System.Drawing.Point(719, 11);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(169, 32);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // CurrentTime
            // 
            this.CurrentTime.Enabled = false;
            this.CurrentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CurrentTime.Location = new System.Drawing.Point(16, 16);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(200, 27);
            this.CurrentTime.TabIndex = 0;
            this.CurrentTime.Value = new System.DateTime(2020, 5, 9, 15, 10, 33, 0);
            // 
            // ClientBox
            // 
            this.ClientBox.Controls.Add(this.Clients);
            this.ClientBox.Controls.Add(this.ClientL);
            this.ClientBox.Controls.Add(this.ClientsBox);
            this.ClientBox.ForeColor = System.Drawing.Color.Snow;
            this.ClientBox.Location = new System.Drawing.Point(17, 95);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(435, 236);
            this.ClientBox.TabIndex = 10;
            this.ClientBox.TabStop = false;
            this.ClientBox.Text = "Клиент";
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.Color.Snow;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients.ForeColor = System.Drawing.Color.Black;
            this.Clients.Location = new System.Drawing.Point(118, 140);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(180, 47);
            this.Clients.TabIndex = 13;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = false;
            // 
            // ClientL
            // 
            this.ClientL.AutoSize = true;
            this.ClientL.ForeColor = System.Drawing.Color.Snow;
            this.ClientL.Location = new System.Drawing.Point(16, 49);
            this.ClientL.Name = "ClientL";
            this.ClientL.Size = new System.Drawing.Size(67, 20);
            this.ClientL.TabIndex = 10;
            this.ClientL.Text = "Клиент";
            // 
            // ClientsBox
            // 
            this.ClientsBox.FormattingEnabled = true;
            this.ClientsBox.Location = new System.Drawing.Point(137, 46);
            this.ClientsBox.Name = "ClientsBox";
            this.ClientsBox.Size = new System.Drawing.Size(197, 28);
            this.ClientsBox.TabIndex = 9;
            // 
            // SpecialistBox
            // 
            this.SpecialistBox.Controls.Add(this.Specialsits);
            this.SpecialistBox.Controls.Add(this.SpecialistL);
            this.SpecialistBox.Controls.Add(this.SpecialistsBox);
            this.SpecialistBox.ForeColor = System.Drawing.Color.Snow;
            this.SpecialistBox.Location = new System.Drawing.Point(17, 337);
            this.SpecialistBox.Name = "SpecialistBox";
            this.SpecialistBox.Size = new System.Drawing.Size(435, 225);
            this.SpecialistBox.TabIndex = 11;
            this.SpecialistBox.TabStop = false;
            this.SpecialistBox.Text = "Специалист";
            // 
            // Specialsits
            // 
            this.Specialsits.BackColor = System.Drawing.Color.Snow;
            this.Specialsits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Specialsits.ForeColor = System.Drawing.Color.Black;
            this.Specialsits.Location = new System.Drawing.Point(118, 130);
            this.Specialsits.Name = "Specialsits";
            this.Specialsits.Size = new System.Drawing.Size(180, 47);
            this.Specialsits.TabIndex = 16;
            this.Specialsits.Text = "Специалисты";
            this.Specialsits.UseVisualStyleBackColor = false;
            // 
            // SpecialistL
            // 
            this.SpecialistL.AutoSize = true;
            this.SpecialistL.ForeColor = System.Drawing.Color.Snow;
            this.SpecialistL.Location = new System.Drawing.Point(16, 36);
            this.SpecialistL.Name = "SpecialistL";
            this.SpecialistL.Size = new System.Drawing.Size(102, 20);
            this.SpecialistL.TabIndex = 15;
            this.SpecialistL.Text = "Специалист";
            // 
            // SpecialistsBox
            // 
            this.SpecialistsBox.FormattingEnabled = true;
            this.SpecialistsBox.Location = new System.Drawing.Point(137, 33);
            this.SpecialistsBox.Name = "SpecialistsBox";
            this.SpecialistsBox.Size = new System.Drawing.Size(197, 28);
            this.SpecialistsBox.TabIndex = 14;
            // 
            // ServiceBox
            // 
            this.ServiceBox.ForeColor = System.Drawing.Color.Snow;
            this.ServiceBox.Location = new System.Drawing.Point(479, 95);
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(480, 236);
            this.ServiceBox.TabIndex = 12;
            this.ServiceBox.TabStop = false;
            this.ServiceBox.Text = "Услуга";
            // 
            // MoreBox
            // 
            this.MoreBox.Controls.Add(this.StatusEdit);
            this.MoreBox.Controls.Add(this.SumEdit);
            this.MoreBox.Controls.Add(this.DateOfBeginEdit);
            this.MoreBox.Controls.Add(this.DateOfEndEdit);
            this.MoreBox.Controls.Add(this.StatusL);
            this.MoreBox.Controls.Add(this.SumL);
            this.MoreBox.Controls.Add(this.DateOfEndL);
            this.MoreBox.Controls.Add(this.DateOfBeginL);
            this.MoreBox.ForeColor = System.Drawing.Color.Snow;
            this.MoreBox.Location = new System.Drawing.Point(479, 337);
            this.MoreBox.Name = "MoreBox";
            this.MoreBox.Size = new System.Drawing.Size(480, 225);
            this.MoreBox.TabIndex = 11;
            this.MoreBox.TabStop = false;
            this.MoreBox.Text = "Дополнительные атрибуты";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.DateOfReceiveDP);
            this.HeaderPanel.Controls.Add(this.LogoPic);
            this.HeaderPanel.Controls.Add(this.DataOfReceivingEditL);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(971, 72);
            this.HeaderPanel.TabIndex = 13;
            // 
            // DateOfReceiveDP
            // 
            this.DateOfReceiveDP.Location = new System.Drawing.Point(187, 20);
            this.DateOfReceiveDP.Name = "DateOfReceiveDP";
            this.DateOfReceiveDP.Size = new System.Drawing.Size(200, 27);
            this.DateOfReceiveDP.TabIndex = 11;
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.LogoPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoPic.Enabled = false;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoPic.Location = new System.Drawing.Point(645, 0);
            this.LogoPic.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.LogoPic.Size = new System.Drawing.Size(326, 72);
            this.LogoPic.TabIndex = 10;
            this.LogoPic.TabStop = false;
            // 
            // CurrentTimeTicker
            // 
            this.CurrentTimeTicker.Enabled = true;
            this.CurrentTimeTicker.Interval = 1000;
            this.CurrentTimeTicker.Tick += new System.EventHandler(this.CurrentTimeTicker_Tick);
            // 
            // DateOfBeginL
            // 
            this.DateOfBeginL.AutoSize = true;
            this.DateOfBeginL.ForeColor = System.Drawing.Color.Snow;
            this.DateOfBeginL.Location = new System.Drawing.Point(11, 44);
            this.DateOfBeginL.Name = "DateOfBeginL";
            this.DateOfBeginL.Size = new System.Drawing.Size(204, 20);
            this.DateOfBeginL.TabIndex = 16;
            this.DateOfBeginL.Text = "Дата начала выполнения";
            // 
            // DateOfEndL
            // 
            this.DateOfEndL.AutoSize = true;
            this.DateOfEndL.ForeColor = System.Drawing.Color.Snow;
            this.DateOfEndL.Location = new System.Drawing.Point(11, 86);
            this.DateOfEndL.Name = "DateOfEndL";
            this.DateOfEndL.Size = new System.Drawing.Size(234, 20);
            this.DateOfEndL.TabIndex = 17;
            this.DateOfEndL.Text = "Дата окончания выполнения";
            // 
            // SumL
            // 
            this.SumL.AutoSize = true;
            this.SumL.ForeColor = System.Drawing.Color.Snow;
            this.SumL.Location = new System.Drawing.Point(11, 127);
            this.SumL.Name = "SumL";
            this.SumL.Size = new System.Drawing.Size(133, 20);
            this.SumL.TabIndex = 18;
            this.SumL.Text = "Итоговая сумма";
            // 
            // StatusL
            // 
            this.StatusL.AutoSize = true;
            this.StatusL.ForeColor = System.Drawing.Color.Snow;
            this.StatusL.Location = new System.Drawing.Point(11, 168);
            this.StatusL.Name = "StatusL";
            this.StatusL.Size = new System.Drawing.Size(164, 20);
            this.StatusL.TabIndex = 19;
            this.StatusL.Text = "Статус выполнения";
            // 
            // DateOfEndEdit
            // 
            this.DateOfEndEdit.Location = new System.Drawing.Point(262, 81);
            this.DateOfEndEdit.Name = "DateOfEndEdit";
            this.DateOfEndEdit.Size = new System.Drawing.Size(200, 27);
            this.DateOfEndEdit.TabIndex = 20;
            // 
            // DateOfBeginEdit
            // 
            this.DateOfBeginEdit.Location = new System.Drawing.Point(262, 42);
            this.DateOfBeginEdit.Name = "DateOfBeginEdit";
            this.DateOfBeginEdit.Size = new System.Drawing.Size(200, 27);
            this.DateOfBeginEdit.TabIndex = 21;
            // 
            // SumEdit
            // 
            this.SumEdit.Location = new System.Drawing.Point(262, 124);
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(200, 27);
            this.SumEdit.TabIndex = 22;
            // 
            // StatusEdit
            // 
            this.StatusEdit.FormattingEnabled = true;
            this.StatusEdit.Location = new System.Drawing.Point(262, 165);
            this.StatusEdit.Name = "StatusEdit";
            this.StatusEdit.Size = new System.Drawing.Size(200, 28);
            this.StatusEdit.TabIndex = 15;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(971, 633);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MoreBox);
            this.Controls.Add(this.ServiceBox);
            this.Controls.Add(this.SpecialistBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.FooterPanel);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrderForm";
            this.Text = "Формирование заказа";
            this.FooterPanel.ResumeLayout(false);
            this.ClientBox.ResumeLayout(false);
            this.ClientBox.PerformLayout();
            this.SpecialistBox.ResumeLayout(false);
            this.SpecialistBox.PerformLayout();
            this.MoreBox.ResumeLayout(false);
            this.MoreBox.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DataOfReceivingEditL;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.GroupBox ClientBox;
        private System.Windows.Forms.GroupBox SpecialistBox;
        private System.Windows.Forms.GroupBox ServiceBox;
        private System.Windows.Forms.GroupBox MoreBox;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.DateTimePicker CurrentTime;
        private System.Windows.Forms.DateTimePicker DateOfReceiveDP;
        private System.Windows.Forms.Timer CurrentTimeTicker;
        private System.Windows.Forms.Label ClientL;
        private System.Windows.Forms.ComboBox ClientsBox;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Specialsits;
        private System.Windows.Forms.Label SpecialistL;
        private System.Windows.Forms.ComboBox SpecialistsBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker DateOfBeginEdit;
        private System.Windows.Forms.DateTimePicker DateOfEndEdit;
        private System.Windows.Forms.Label StatusL;
        private System.Windows.Forms.Label SumL;
        private System.Windows.Forms.Label DateOfEndL;
        private System.Windows.Forms.Label DateOfBeginL;
        private System.Windows.Forms.TextBox SumEdit;
        private System.Windows.Forms.ComboBox StatusEdit;
    }
}