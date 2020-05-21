using System;
using System.Windows.Forms;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void TableSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TableSet != null && TableSet.SelectedItem != null)
            {
                switch (TableSet.SelectedItem.ToString())
                {
                    case "Клиенты":
                        new ClientsReportForm(this).Show();
                        break;

                    case "Специалисты":
                        new SpecialistsReportForm(this).Show();
                        break;

                    case "Заказы":
                        //clients.Close();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
