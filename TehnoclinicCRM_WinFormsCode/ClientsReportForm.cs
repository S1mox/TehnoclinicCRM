using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class ClientsReportForm : Form
    {
        ClientsController controller = new ClientsController();     // Контроллер для работы с таблицей клиентов

        public ClientsReportForm(ReportForm owner)
        {
            InitializeComponent();

            MdiParent = owner;
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            List<string> parametres = new List<string>();
            List<string> values = new List<string>();

            List<char> symbols = new List<char>() { '-', '!', ',', '.', '?', '\'', '/', '/', '(', ')', '*', '%', '+', '=', '&', '^', ':', ';', '#', '№', '@', '"', '`', '~', '<', '>', '|', '[', ']', '{', '}' };

            if (!string.IsNullOrEmpty(ClientEdit.Text))
            {
                parametres.Add("ФИО");
                values.Add(ClientEdit.Text);
            }

            if (!string.IsNullOrEmpty(PhoneNumberEdit.Text))
            {
                parametres.Add("Номер_телефона");
                values.Add(PhoneNumberEdit.Text);
            }

            if (!string.IsNullOrEmpty(PassportEdit.Text))
            {
                parametres.Add("Паспортные_данные");
                values.Add(PassportEdit.Text);
            }

            try
            {
                ClientsGrid.DataSource = null;
                ClientsGrid.DataSource = controller.MultiSelect(parametres, values);

                ClientsGrid.Columns["Id"].Visible = false;

                if (!FIOCB.Checked)
                {
                    ClientsGrid.Columns["ФИО"].Visible = false;
                }
                else
                {
                    ClientsGrid.Columns["ФИО"].Visible = true;
                }

                if (!PassportCB.Checked)
                {
                    ClientsGrid.Columns["Паспортные_данные"].Visible = false;
                }
                else
                {
                    ClientsGrid.Columns["Паспортные_данные"].Visible = true;
                }

                if (!NumberPhoneCB.Checked)
                {
                    ClientsGrid.Columns["Номер_телефона"].Visible = false;
                }
                else
                {
                    ClientsGrid.Columns["Номер_телефона"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void FIOCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            FIOCB.Checked = true;
            PassportCB.Checked = true;
            NumberPhoneCB.Checked = true;

            ClientEdit.Text = null;
            PassportCB.Text = null;
            PhoneNumberEdit.Text = null;
        }

        private void PassportEdit_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
