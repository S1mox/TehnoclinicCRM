using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();

            CurrentTime.Format = DateTimePickerFormat.Custom;
            CurrentTime.CustomFormat = "MM/dd/yyyy HH:mm tt";
        }

        private void CurrentTimeTicker_Tick(object sender, EventArgs e)
        {
            CurrentTime.Value = DateTime.Now;
        }
    }
}
