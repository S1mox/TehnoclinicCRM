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
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SearchL = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.CriteriesBox = new System.Windows.Forms.ComboBox();
            this.SearchCriteriaL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SearchBox.SuspendLayout();
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
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersGrid.Location = new System.Drawing.Point(0, 0);
            this.OrdersGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdersGrid.MultiSelect = false;
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGrid.Size = new System.Drawing.Size(998, 398);
            this.OrdersGrid.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Snow;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(12, 440);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(214, 61);
            this.Delete.TabIndex = 14;
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
            this.SearchBox.Location = new System.Drawing.Point(254, 412);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(732, 104);
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Поиск";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Snow;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(398, 28);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(284, 57);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Location = new System.Drawing.Point(19, 69);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(92, 16);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Строка ввода";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(164, 66);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(161, 23);
            this.SearchText.TabIndex = 9;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // CriteriesBox
            // 
            this.CriteriesBox.FormattingEnabled = true;
            this.CriteriesBox.Items.AddRange(new object[] {
            "Номер заказа",
            "Дата получения",
            "ФИО клиента",
            "Подразделение услуги",
            "Услуга",
            "Предварительная сумма",
            "ФИО специалиста",
            "Дата начала выполнения",
            "Дата окончания выполнения",
            "Итоговая сумма",
            "Статус выполнения заказа"});
            this.CriteriesBox.Location = new System.Drawing.Point(164, 25);
            this.CriteriesBox.Name = "CriteriesBox";
            this.CriteriesBox.Size = new System.Drawing.Size(161, 23);
            this.CriteriesBox.TabIndex = 8;
            // 
            // SearchCriteriaL
            // 
            this.SearchCriteriaL.AutoSize = true;
            this.SearchCriteriaL.Location = new System.Drawing.Point(19, 28);
            this.SearchCriteriaL.Name = "SearchCriteriaL";
            this.SearchCriteriaL.Size = new System.Drawing.Size(118, 16);
            this.SearchCriteriaL.TabIndex = 7;
            this.SearchCriteriaL.Text = "Критерий поиска";
            // 
            // OrdersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(998, 532);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.OrdersGrid);
            this.Font = new System.Drawing.Font("Cambria", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdersForms";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox CriteriesBox;
        private System.Windows.Forms.Label SearchCriteriaL;
    }
}