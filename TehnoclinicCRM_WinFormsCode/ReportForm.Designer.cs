namespace TehnoclinicCRM_WinFormsCode
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.TableSet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TableSet
            // 
            this.TableSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TableSet.Font = new System.Drawing.Font("Cambria", 12F);
            this.TableSet.FormattingEnabled = true;
            this.TableSet.Items.AddRange(new object[] {
            "Специалисты",
            "Клиенты",
            "Заказы"});
            this.TableSet.Location = new System.Drawing.Point(0, 0);
            this.TableSet.Name = "TableSet";
            this.TableSet.Size = new System.Drawing.Size(1284, 27);
            this.TableSet.TabIndex = 1;
            this.TableSet.SelectedIndexChanged += new System.EventHandler(this.TableSet_SelectedIndexChanged);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.TableSet);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.Text = "Форма отчётов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TableSet;
    }
}