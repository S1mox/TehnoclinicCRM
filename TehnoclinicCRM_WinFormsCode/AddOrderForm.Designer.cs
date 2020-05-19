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
            this.PhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.PassportEdit = new System.Windows.Forms.TextBox();
            this.ClientEdit = new System.Windows.Forms.TextBox();
            this.PhoneNumberEditL = new System.Windows.Forms.Label();
            this.PassportEditL = new System.Windows.Forms.Label();
            this.ClientEditL = new System.Windows.Forms.Label();
            this.Clients = new System.Windows.Forms.Button();
            this.ClientL = new System.Windows.Forms.Label();
            this.ClientsBox = new System.Windows.Forms.ComboBox();
            this.SpecialistBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberSpEdit = new System.Windows.Forms.TextBox();
            this.PositionEdit = new System.Windows.Forms.TextBox();
            this.FIOSpEdit = new System.Windows.Forms.TextBox();
            this.PhoneNumberL = new System.Windows.Forms.Label();
            this.PositionL = new System.Windows.Forms.Label();
            this.FIOSpL = new System.Windows.Forms.Label();
            this.Specialists = new System.Windows.Forms.Button();
            this.SpecialistsL = new System.Windows.Forms.Label();
            this.SpecialistsBox = new System.Windows.Forms.ComboBox();
            this.ServiceBox = new System.Windows.Forms.GroupBox();
            this.SubdivisionsBox = new System.Windows.Forms.ComboBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceL = new System.Windows.Forms.Label();
            this.SubdivisionL = new System.Windows.Forms.Label();
            this.Services = new System.Windows.Forms.Button();
            this.ServiceL = new System.Windows.Forms.Label();
            this.ServicesBox = new System.Windows.Forms.ComboBox();
            this.MoreBox = new System.Windows.Forms.GroupBox();
            this.StatusEdit = new System.Windows.Forms.ComboBox();
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.DateOfBeginEdit = new System.Windows.Forms.DateTimePicker();
            this.DateOfEndEdit = new System.Windows.Forms.DateTimePicker();
            this.StatusL = new System.Windows.Forms.Label();
            this.SumL = new System.Windows.Forms.Label();
            this.DateOfEndL = new System.Windows.Forms.Label();
            this.DateOfBeginL = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.DateOfReceiveDP = new System.Windows.Forms.DateTimePicker();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.CurrentTimeTicker = new System.Windows.Forms.Timer(this.components);
            this.FooterPanel.SuspendLayout();
            this.ClientBox.SuspendLayout();
            this.SpecialistBox.SuspendLayout();
            this.ServiceBox.SuspendLayout();
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
            this.FooterPanel.Location = new System.Drawing.Point(0, 588);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(882, 45);
            this.FooterPanel.TabIndex = 8;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Snow;
            this.Reset.Location = new System.Drawing.Point(526, 7);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(169, 32);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.ForeColor = System.Drawing.Color.Snow;
            this.Add.Location = new System.Drawing.Point(701, 7);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(169, 32);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CurrentTime
            // 
            this.CurrentTime.Checked = false;
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
            this.ClientBox.Controls.Add(this.PhoneNumberEdit);
            this.ClientBox.Controls.Add(this.PassportEdit);
            this.ClientBox.Controls.Add(this.ClientEdit);
            this.ClientBox.Controls.Add(this.PhoneNumberEditL);
            this.ClientBox.Controls.Add(this.PassportEditL);
            this.ClientBox.Controls.Add(this.ClientEditL);
            this.ClientBox.Controls.Add(this.Clients);
            this.ClientBox.Controls.Add(this.ClientL);
            this.ClientBox.Controls.Add(this.ClientsBox);
            this.ClientBox.ForeColor = System.Drawing.Color.Snow;
            this.ClientBox.Location = new System.Drawing.Point(17, 90);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(341, 236);
            this.ClientBox.TabIndex = 10;
            this.ClientBox.TabStop = false;
            this.ClientBox.Text = "Клиент";
            // 
            // PhoneNumberEdit
            // 
            this.PhoneNumberEdit.Location = new System.Drawing.Point(125, 149);
            this.PhoneNumberEdit.Name = "PhoneNumberEdit";
            this.PhoneNumberEdit.ReadOnly = true;
            this.PhoneNumberEdit.Size = new System.Drawing.Size(190, 27);
            this.PhoneNumberEdit.TabIndex = 19;
            // 
            // PassportEdit
            // 
            this.PassportEdit.Location = new System.Drawing.Point(125, 108);
            this.PassportEdit.Name = "PassportEdit";
            this.PassportEdit.ReadOnly = true;
            this.PassportEdit.Size = new System.Drawing.Size(190, 27);
            this.PassportEdit.TabIndex = 18;
            // 
            // ClientEdit
            // 
            this.ClientEdit.Location = new System.Drawing.Point(125, 67);
            this.ClientEdit.Name = "ClientEdit";
            this.ClientEdit.ReadOnly = true;
            this.ClientEdit.Size = new System.Drawing.Size(190, 27);
            this.ClientEdit.TabIndex = 16;
            // 
            // PhoneNumberEditL
            // 
            this.PhoneNumberEditL.AutoSize = true;
            this.PhoneNumberEditL.Location = new System.Drawing.Point(17, 152);
            this.PhoneNumberEditL.Name = "PhoneNumberEditL";
            this.PhoneNumberEditL.Size = new System.Drawing.Size(75, 20);
            this.PhoneNumberEditL.TabIndex = 17;
            this.PhoneNumberEditL.Text = "Телефон";
            // 
            // PassportEditL
            // 
            this.PassportEditL.AutoSize = true;
            this.PassportEditL.Location = new System.Drawing.Point(17, 111);
            this.PassportEditL.Name = "PassportEditL";
            this.PassportEditL.Size = new System.Drawing.Size(73, 20);
            this.PassportEditL.TabIndex = 15;
            this.PassportEditL.Text = "Паспорт";
            // 
            // ClientEditL
            // 
            this.ClientEditL.AutoSize = true;
            this.ClientEditL.Location = new System.Drawing.Point(17, 70);
            this.ClientEditL.Name = "ClientEditL";
            this.ClientEditL.Size = new System.Drawing.Size(45, 20);
            this.ClientEditL.TabIndex = 14;
            this.ClientEditL.Text = "ФИО";
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.Color.Snow;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients.ForeColor = System.Drawing.Color.Black;
            this.Clients.Location = new System.Drawing.Point(79, 190);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(180, 32);
            this.Clients.TabIndex = 13;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = false;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // ClientL
            // 
            this.ClientL.AutoSize = true;
            this.ClientL.ForeColor = System.Drawing.Color.Snow;
            this.ClientL.Location = new System.Drawing.Point(17, 33);
            this.ClientL.Name = "ClientL";
            this.ClientL.Size = new System.Drawing.Size(67, 20);
            this.ClientL.TabIndex = 10;
            this.ClientL.Text = "Клиент";
            // 
            // ClientsBox
            // 
            this.ClientsBox.FormattingEnabled = true;
            this.ClientsBox.Location = new System.Drawing.Point(125, 30);
            this.ClientsBox.Name = "ClientsBox";
            this.ClientsBox.Size = new System.Drawing.Size(190, 28);
            this.ClientsBox.TabIndex = 9;
            this.ClientsBox.SelectedIndexChanged += new System.EventHandler(this.ClientsBox_SelectedIndexChanged);
            // 
            // SpecialistBox
            // 
            this.SpecialistBox.Controls.Add(this.PhoneNumberSpEdit);
            this.SpecialistBox.Controls.Add(this.PositionEdit);
            this.SpecialistBox.Controls.Add(this.FIOSpEdit);
            this.SpecialistBox.Controls.Add(this.PhoneNumberL);
            this.SpecialistBox.Controls.Add(this.PositionL);
            this.SpecialistBox.Controls.Add(this.FIOSpL);
            this.SpecialistBox.Controls.Add(this.Specialists);
            this.SpecialistBox.Controls.Add(this.SpecialistsL);
            this.SpecialistBox.Controls.Add(this.SpecialistsBox);
            this.SpecialistBox.ForeColor = System.Drawing.Color.Snow;
            this.SpecialistBox.Location = new System.Drawing.Point(17, 337);
            this.SpecialistBox.Name = "SpecialistBox";
            this.SpecialistBox.Size = new System.Drawing.Size(341, 233);
            this.SpecialistBox.TabIndex = 11;
            this.SpecialistBox.TabStop = false;
            this.SpecialistBox.Text = "Специалист";
            // 
            // PhoneNumberSpEdit
            // 
            this.PhoneNumberSpEdit.Location = new System.Drawing.Point(125, 144);
            this.PhoneNumberSpEdit.Name = "PhoneNumberSpEdit";
            this.PhoneNumberSpEdit.ReadOnly = true;
            this.PhoneNumberSpEdit.Size = new System.Drawing.Size(190, 27);
            this.PhoneNumberSpEdit.TabIndex = 28;
            // 
            // PositionEdit
            // 
            this.PositionEdit.Location = new System.Drawing.Point(125, 103);
            this.PositionEdit.Name = "PositionEdit";
            this.PositionEdit.ReadOnly = true;
            this.PositionEdit.Size = new System.Drawing.Size(190, 27);
            this.PositionEdit.TabIndex = 27;
            // 
            // FIOSpEdit
            // 
            this.FIOSpEdit.Location = new System.Drawing.Point(125, 62);
            this.FIOSpEdit.Name = "FIOSpEdit";
            this.FIOSpEdit.ReadOnly = true;
            this.FIOSpEdit.Size = new System.Drawing.Size(190, 27);
            this.FIOSpEdit.TabIndex = 25;
            // 
            // PhoneNumberL
            // 
            this.PhoneNumberL.AutoSize = true;
            this.PhoneNumberL.Location = new System.Drawing.Point(17, 147);
            this.PhoneNumberL.Name = "PhoneNumberL";
            this.PhoneNumberL.Size = new System.Drawing.Size(75, 20);
            this.PhoneNumberL.TabIndex = 26;
            this.PhoneNumberL.Text = "Телефон";
            // 
            // PositionL
            // 
            this.PositionL.AutoSize = true;
            this.PositionL.Location = new System.Drawing.Point(17, 106);
            this.PositionL.Name = "PositionL";
            this.PositionL.Size = new System.Drawing.Size(96, 20);
            this.PositionL.TabIndex = 24;
            this.PositionL.Text = "Должность";
            // 
            // FIOSpL
            // 
            this.FIOSpL.AutoSize = true;
            this.FIOSpL.Location = new System.Drawing.Point(17, 65);
            this.FIOSpL.Name = "FIOSpL";
            this.FIOSpL.Size = new System.Drawing.Size(45, 20);
            this.FIOSpL.TabIndex = 23;
            this.FIOSpL.Text = "ФИО";
            // 
            // Specialists
            // 
            this.Specialists.BackColor = System.Drawing.Color.Snow;
            this.Specialists.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Specialists.ForeColor = System.Drawing.Color.Black;
            this.Specialists.Location = new System.Drawing.Point(79, 185);
            this.Specialists.Name = "Specialists";
            this.Specialists.Size = new System.Drawing.Size(180, 32);
            this.Specialists.TabIndex = 22;
            this.Specialists.Text = "Специалисты";
            this.Specialists.UseVisualStyleBackColor = false;
            this.Specialists.Click += new System.EventHandler(this.Specialists_Click);
            // 
            // SpecialistsL
            // 
            this.SpecialistsL.AutoSize = true;
            this.SpecialistsL.ForeColor = System.Drawing.Color.Snow;
            this.SpecialistsL.Location = new System.Drawing.Point(17, 28);
            this.SpecialistsL.Name = "SpecialistsL";
            this.SpecialistsL.Size = new System.Drawing.Size(102, 20);
            this.SpecialistsL.TabIndex = 21;
            this.SpecialistsL.Text = "Специалист";
            // 
            // SpecialistsBox
            // 
            this.SpecialistsBox.FormattingEnabled = true;
            this.SpecialistsBox.Location = new System.Drawing.Point(125, 25);
            this.SpecialistsBox.Name = "SpecialistsBox";
            this.SpecialistsBox.Size = new System.Drawing.Size(190, 28);
            this.SpecialistsBox.TabIndex = 20;
            this.SpecialistsBox.SelectedIndexChanged += new System.EventHandler(this.SpecialistsBox_SelectedIndexChanged);
            // 
            // ServiceBox
            // 
            this.ServiceBox.Controls.Add(this.SubdivisionsBox);
            this.ServiceBox.Controls.Add(this.PriceBox);
            this.ServiceBox.Controls.Add(this.PriceL);
            this.ServiceBox.Controls.Add(this.SubdivisionL);
            this.ServiceBox.Controls.Add(this.Services);
            this.ServiceBox.Controls.Add(this.ServiceL);
            this.ServiceBox.Controls.Add(this.ServicesBox);
            this.ServiceBox.ForeColor = System.Drawing.Color.Snow;
            this.ServiceBox.Location = new System.Drawing.Point(377, 90);
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(493, 236);
            this.ServiceBox.TabIndex = 12;
            this.ServiceBox.TabStop = false;
            this.ServiceBox.Text = "Услуга";
            // 
            // SubdivisionsBox
            // 
            this.SubdivisionsBox.FormattingEnabled = true;
            this.SubdivisionsBox.Location = new System.Drawing.Point(138, 26);
            this.SubdivisionsBox.Name = "SubdivisionsBox";
            this.SubdivisionsBox.Size = new System.Drawing.Size(348, 28);
            this.SubdivisionsBox.TabIndex = 28;
            this.SubdivisionsBox.SelectedIndexChanged += new System.EventHandler(this.UpdateServices);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(138, 111);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(348, 27);
            this.PriceBox.TabIndex = 27;
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Location = new System.Drawing.Point(11, 111);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(46, 20);
            this.PriceL.TabIndex = 24;
            this.PriceL.Text = "Цена";
            // 
            // SubdivisionL
            // 
            this.SubdivisionL.AutoSize = true;
            this.SubdivisionL.Location = new System.Drawing.Point(11, 29);
            this.SubdivisionL.Name = "SubdivisionL";
            this.SubdivisionL.Size = new System.Drawing.Size(126, 20);
            this.SubdivisionL.TabIndex = 23;
            this.SubdivisionL.Text = "Подразделение";
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.Snow;
            this.Services.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Services.ForeColor = System.Drawing.Color.Black;
            this.Services.Location = new System.Drawing.Point(155, 190);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(180, 32);
            this.Services.TabIndex = 22;
            this.Services.Text = "Услуги";
            this.Services.UseVisualStyleBackColor = false;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // ServiceL
            // 
            this.ServiceL.AutoSize = true;
            this.ServiceL.ForeColor = System.Drawing.Color.Snow;
            this.ServiceL.Location = new System.Drawing.Point(11, 70);
            this.ServiceL.Name = "ServiceL";
            this.ServiceL.Size = new System.Drawing.Size(60, 20);
            this.ServiceL.TabIndex = 21;
            this.ServiceL.Text = "Услуга";
            // 
            // ServicesBox
            // 
            this.ServicesBox.DropDownWidth = 400;
            this.ServicesBox.FormattingEnabled = true;
            this.ServicesBox.Location = new System.Drawing.Point(138, 70);
            this.ServicesBox.Name = "ServicesBox";
            this.ServicesBox.Size = new System.Drawing.Size(348, 28);
            this.ServicesBox.TabIndex = 20;
            this.ServicesBox.SelectedIndexChanged += new System.EventHandler(this.ServicesBox_SelectedIndexChanged);
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
            this.MoreBox.Location = new System.Drawing.Point(377, 337);
            this.MoreBox.Name = "MoreBox";
            this.MoreBox.Size = new System.Drawing.Size(493, 233);
            this.MoreBox.TabIndex = 11;
            this.MoreBox.TabStop = false;
            this.MoreBox.Text = "Дополнительные атрибуты";
            // 
            // StatusEdit
            // 
            this.StatusEdit.FormattingEnabled = true;
            this.StatusEdit.Items.AddRange(new object[] {
            "Оформлен",
            "Ремонт",
            "Закрыт"});
            this.StatusEdit.Location = new System.Drawing.Point(264, 165);
            this.StatusEdit.Name = "StatusEdit";
            this.StatusEdit.Size = new System.Drawing.Size(200, 28);
            this.StatusEdit.TabIndex = 15;
            // 
            // SumEdit
            // 
            this.SumEdit.Location = new System.Drawing.Point(264, 124);
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(200, 27);
            this.SumEdit.TabIndex = 22;
            // 
            // DateOfBeginEdit
            // 
            this.DateOfBeginEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBeginEdit.Location = new System.Drawing.Point(264, 42);
            this.DateOfBeginEdit.Name = "DateOfBeginEdit";
            this.DateOfBeginEdit.Size = new System.Drawing.Size(200, 27);
            this.DateOfBeginEdit.TabIndex = 21;
            this.DateOfBeginEdit.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // DateOfEndEdit
            // 
            this.DateOfEndEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfEndEdit.Location = new System.Drawing.Point(264, 81);
            this.DateOfEndEdit.Name = "DateOfEndEdit";
            this.DateOfEndEdit.Size = new System.Drawing.Size(200, 27);
            this.DateOfEndEdit.TabIndex = 20;
            this.DateOfEndEdit.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
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
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.DateOfReceiveDP);
            this.HeaderPanel.Controls.Add(this.LogoPic);
            this.HeaderPanel.Controls.Add(this.DataOfReceivingEditL);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(882, 72);
            this.HeaderPanel.TabIndex = 13;
            // 
            // DateOfReceiveDP
            // 
            this.DateOfReceiveDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfReceiveDP.Location = new System.Drawing.Point(187, 20);
            this.DateOfReceiveDP.Name = "DateOfReceiveDP";
            this.DateOfReceiveDP.Size = new System.Drawing.Size(200, 27);
            this.DateOfReceiveDP.TabIndex = 11;
            this.DateOfReceiveDP.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.LogoPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoPic.Enabled = false;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoPic.Location = new System.Drawing.Point(556, 0);
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
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(882, 633);
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
            this.ServiceBox.ResumeLayout(false);
            this.ServiceBox.PerformLayout();
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
        private System.Windows.Forms.TextBox PhoneNumberSpEdit;
        private System.Windows.Forms.TextBox PositionEdit;
        private System.Windows.Forms.TextBox FIOSpEdit;
        private System.Windows.Forms.Label PhoneNumberL;
        private System.Windows.Forms.Label PositionL;
        private System.Windows.Forms.Label FIOSpL;
        private System.Windows.Forms.Button Specialists;
        private System.Windows.Forms.Label SpecialistsL;
        private System.Windows.Forms.ComboBox SpecialistsBox;
        private System.Windows.Forms.TextBox PhoneNumberEdit;
        private System.Windows.Forms.TextBox PassportEdit;
        private System.Windows.Forms.TextBox ClientEdit;
        private System.Windows.Forms.Label PhoneNumberEditL;
        private System.Windows.Forms.Label PassportEditL;
        private System.Windows.Forms.Label ClientEditL;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Label ClientL;
        private System.Windows.Forms.ComboBox ClientsBox;
        private System.Windows.Forms.ComboBox SubdivisionsBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Label SubdivisionL;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Label ServiceL;
        private System.Windows.Forms.ComboBox ServicesBox;
    }
}