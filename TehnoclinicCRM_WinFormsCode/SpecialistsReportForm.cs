using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class SpecialistsReportForm : Form
    {
        SpecialistsController controller = new SpecialistsController();

        public SpecialistsReportForm(ReportForm owner)
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

            if (!string.IsNullOrEmpty(SpecialistEdit.Text))
            {
                parametres.Add("ФИО");
                values.Add(SpecialistEdit.Text);
            }

            if (!string.IsNullOrEmpty(PhoneNumberEdit.Text))
            {
                parametres.Add("Телефон");
                values.Add(PhoneNumberEdit.Text);
            }

            if (!string.IsNullOrEmpty(PositionEdit.Text))
            {
                parametres.Add("Должность");
                values.Add(PositionEdit.Text);
            }

            try
            {
                SpecialistGrid.DataSource = null;
                SpecialistGrid.DataSource = controller.MultiSelect(parametres, values);

                SpecialistGrid.Columns["Id"].Visible = false;

                if (!FIOCB.Checked)
                {
                    SpecialistGrid.Columns["ФИО"].Visible = false;
                }
                else
                {
                    SpecialistGrid.Columns["ФИО"].Visible = true;
                }

                if (!PositionCB.Checked)
                {
                    SpecialistGrid.Columns["Должность"].Visible = false;
                }
                else
                {
                    SpecialistGrid.Columns["Должность"].Visible = true;
                }

                if (!NumberPhoneCB.Checked)
                {
                    SpecialistGrid.Columns["Телефон"].Visible = false;
                }
                else
                {
                    SpecialistGrid.Columns["Телефон"].Visible = true;
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
            PositionCB.Checked = true;
            NumberPhoneCB.Checked = true;

            SpecialistEdit.Text = null;
            PositionCB.Text = null;
            PhoneNumberEdit.Text = null;
        }

        private void PassportEdit_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
