namespace TehnoclinicCRM_WinFormsCode
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Services = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.FormedOrders = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.Specialists = new System.Windows.Forms.Button();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.LeftInfoPanel = new System.Windows.Forms.Panel();
            this.ContactsLabel = new System.Windows.Forms.Label();
            this.GraphicsLabel = new System.Windows.Forms.Label();
            this.RightInfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.VisitSite = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.HeaderPicPanel = new System.Windows.Forms.Panel();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.LeftInfoPanel.SuspendLayout();
            this.RightInfoPanel.SuspendLayout();
            this.HeaderPicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.MenuPanel.Controls.Add(this.Services);
            this.MenuPanel.Controls.Add(this.CreateOrder);
            this.MenuPanel.Controls.Add(this.FormedOrders);
            this.MenuPanel.Controls.Add(this.Clients);
            this.MenuPanel.Controls.Add(this.Specialists);
            this.MenuPanel.Controls.Add(this.AdressLabel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.MenuPanel.ForeColor = System.Drawing.Color.White;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(342, 641);
            this.MenuPanel.TabIndex = 0;
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.White;
            this.Services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Services.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Services.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Services.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.Services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Services.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Services.Location = new System.Drawing.Point(18, 325);
            this.Services.Margin = new System.Windows.Forms.Padding(0);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(302, 52);
            this.Services.TabIndex = 7;
            this.Services.Text = "Услуги";
            this.Services.UseVisualStyleBackColor = false;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.Color.White;
            this.CreateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateOrder.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.CreateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.CreateOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreateOrder.Location = new System.Drawing.Point(18, 249);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(0);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(302, 52);
            this.CreateOrder.TabIndex = 6;
            this.CreateOrder.Text = "Формирование заказа";
            this.CreateOrder.UseVisualStyleBackColor = false;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // FormedOrders
            // 
            this.FormedOrders.BackColor = System.Drawing.Color.White;
            this.FormedOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FormedOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormedOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FormedOrders.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.FormedOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.FormedOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FormedOrders.Location = new System.Drawing.Point(18, 174);
            this.FormedOrders.Margin = new System.Windows.Forms.Padding(0);
            this.FormedOrders.Name = "FormedOrders";
            this.FormedOrders.Size = new System.Drawing.Size(302, 52);
            this.FormedOrders.TabIndex = 5;
            this.FormedOrders.Text = "Сформированные заказы";
            this.FormedOrders.UseVisualStyleBackColor = false;
            this.FormedOrders.Click += new System.EventHandler(this.FormedOrders_Click);
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.Color.White;
            this.Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clients.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.Clients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Clients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clients.Location = new System.Drawing.Point(18, 98);
            this.Clients.Margin = new System.Windows.Forms.Padding(0);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(302, 52);
            this.Clients.TabIndex = 4;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = false;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Specialists
            // 
            this.Specialists.BackColor = System.Drawing.Color.White;
            this.Specialists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Specialists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Specialists.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Specialists.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.Specialists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Specialists.Location = new System.Drawing.Point(18, 22);
            this.Specialists.Margin = new System.Windows.Forms.Padding(0);
            this.Specialists.Name = "Specialists";
            this.Specialists.Size = new System.Drawing.Size(302, 52);
            this.Specialists.TabIndex = 3;
            this.Specialists.Text = "Специалисты";
            this.Specialists.UseVisualStyleBackColor = false;
            this.Specialists.Click += new System.EventHandler(this.Specialists_Click);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.AdressLabel.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.AdressLabel.ForeColor = System.Drawing.Color.White;
            this.AdressLabel.Image = ((System.Drawing.Image)(resources.GetObject("AdressLabel.Image")));
            this.AdressLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdressLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AdressLabel.Location = new System.Drawing.Point(15, 460);
            this.AdressLabel.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.AdressLabel.Size = new System.Drawing.Size(313, 162);
            this.AdressLabel.TabIndex = 2;
            this.AdressLabel.Text = "         \r\n\r\n\r\nг. Гомель, ул. Интернациональная 5, \r\nЧСУП «ТехноКлиника»\r\n\r\n© 201" +
    "5 «ТехноКлиника»";
            this.AdressLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Controls.Add(this.LeftInfoPanel);
            this.InfoPanel.Controls.Add(this.RightInfoPanel);
            this.InfoPanel.Controls.Add(this.HeaderPicPanel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(342, 0);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(609, 641);
            this.InfoPanel.TabIndex = 1;
            // 
            // LeftInfoPanel
            // 
            this.LeftInfoPanel.BackColor = System.Drawing.Color.White;
            this.LeftInfoPanel.Controls.Add(this.ContactsLabel);
            this.LeftInfoPanel.Controls.Add(this.GraphicsLabel);
            this.LeftInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftInfoPanel.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.LeftInfoPanel.Location = new System.Drawing.Point(0, 122);
            this.LeftInfoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LeftInfoPanel.Name = "LeftInfoPanel";
            this.LeftInfoPanel.Size = new System.Drawing.Size(290, 519);
            this.LeftInfoPanel.TabIndex = 3;
            // 
            // ContactsLabel
            // 
            this.ContactsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.ContactsLabel.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.ContactsLabel.ForeColor = System.Drawing.Color.White;
            this.ContactsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContactsLabel.Location = new System.Drawing.Point(16, 331);
            this.ContactsLabel.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ContactsLabel.Name = "ContactsLabel";
            this.ContactsLabel.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ContactsLabel.Size = new System.Drawing.Size(244, 158);
            this.ContactsLabel.TabIndex = 2;
            this.ContactsLabel.Text = "тел. +375 (29) 260 66 66\r\n\r\nтел. +375 (29) 188 60 66\r\n\r\nфакс. ‎+375 (232) 31-95-5" +
    "2\r\n\r\ne-mail. tehnoclinic@gmail.com";
            // 
            // GraphicsLabel
            // 
            this.GraphicsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.GraphicsLabel.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.GraphicsLabel.ForeColor = System.Drawing.Color.White;
            this.GraphicsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GraphicsLabel.Location = new System.Drawing.Point(20, 11);
            this.GraphicsLabel.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.GraphicsLabel.Name = "GraphicsLabel";
            this.GraphicsLabel.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.GraphicsLabel.Size = new System.Drawing.Size(239, 241);
            this.GraphicsLabel.TabIndex = 1;
            this.GraphicsLabel.Text = "График работы\r\nпн-пт: с 10:00 до 19:00\r\n\r\nсб: с 11:00 до 17:00\r\n\r\nвс: выходной";
            // 
            // RightInfoPanel
            // 
            this.RightInfoPanel.BackColor = System.Drawing.Color.White;
            this.RightInfoPanel.Controls.Add(this.label1);
            this.RightInfoPanel.Controls.Add(this.VisitSite);
            this.RightInfoPanel.Controls.Add(this.Exit);
            this.RightInfoPanel.Controls.Add(this.Help);
            this.RightInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightInfoPanel.Location = new System.Drawing.Point(290, 122);
            this.RightInfoPanel.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.RightInfoPanel.Name = "RightInfoPanel";
            this.RightInfoPanel.Size = new System.Drawing.Size(319, 519);
            this.RightInfoPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 7F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.label1.Size = new System.Drawing.Size(259, 241);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // VisitSite
            // 
            this.VisitSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.VisitSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VisitSite.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.VisitSite.ForeColor = System.Drawing.Color.White;
            this.VisitSite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VisitSite.Location = new System.Drawing.Point(29, 389);
            this.VisitSite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VisitSite.Name = "VisitSite";
            this.VisitSite.Size = new System.Drawing.Size(259, 46);
            this.VisitSite.TabIndex = 3;
            this.VisitSite.Text = "Посетить сайт";
            this.VisitSite.UseVisualStyleBackColor = false;
            this.VisitSite.Click += new System.EventHandler(this.VisitSite_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.Location = new System.Drawing.Point(29, 442);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(259, 46);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Help.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Help.Location = new System.Drawing.Point(29, 331);
            this.Help.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(259, 52);
            this.Help.TabIndex = 2;
            this.Help.Text = "Справка";
            this.Help.UseVisualStyleBackColor = false;
            // 
            // HeaderPicPanel
            // 
            this.HeaderPicPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPicPanel.Controls.Add(this.LogoPic);
            this.HeaderPicPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPicPanel.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.HeaderPicPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPicPanel.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.HeaderPicPanel.Name = "HeaderPicPanel";
            this.HeaderPicPanel.Padding = new System.Windows.Forms.Padding(0, 22, 0, 11);
            this.HeaderPicPanel.Size = new System.Drawing.Size(609, 122);
            this.HeaderPicPanel.TabIndex = 1;
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.LogoPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoPic.Enabled = false;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.Location = new System.Drawing.Point(147, 22);
            this.LogoPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.LogoPic.Size = new System.Drawing.Size(462, 89);
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 641);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Tehnoclinic";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.LeftInfoPanel.ResumeLayout(false);
            this.RightInfoPanel.ResumeLayout(false);
            this.HeaderPicPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel HeaderPicPanel;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Panel RightInfoPanel;
        private System.Windows.Forms.Panel LeftInfoPanel;
        private System.Windows.Forms.Label GraphicsLabel;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button VisitSite;
        private System.Windows.Forms.Label ContactsLabel;
        private System.Windows.Forms.Button Specialists;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button FormedOrders;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Label label1;
    }
}

