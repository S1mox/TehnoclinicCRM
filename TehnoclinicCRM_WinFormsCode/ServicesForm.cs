using System;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class ServicesForm : Form
    {
        ServiceController controller = new ServiceController();

        public ServicesForm()
        {
            InitializeComponent();

            UpdateTable();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из формы
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTable()
        {
            ServicesGrid.DataSource = controller.UpdateTable();
            ServicesGrid.Columns[0].Visible = false;
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (SearchText != null && SearchText.Text.Length > 0 && CriteriesBox.SelectedItem != null)
            {
                try
                {
                    switch (CriteriesBox.SelectedItem.ToString())
                    {
                        case "Подразделение":
                            ServicesGrid.DataSource = null;
                            ServicesGrid.DataSource = controller.Select("Подразделение", SearchText.Text);
                            break;

                        case "Услуга":
                            ServicesGrid.DataSource = null;
                            ServicesGrid.DataSource = controller.Select("Услуга", SearchText.Text);
                            break;

                        case "Цена":
                            ServicesGrid.DataSource = null;
                            ServicesGrid.DataSource = controller.Select("Цена", SearchText.Text);
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                UpdateTable();
            }
        }

        private void Create_ExcelReport(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = $"Отчет по услугам за {DateTime.Now.ToShortDateString()}";
            save.DefaultExt = "xlsx";
            save.AddExtension = true;
            save.Filter = "Лист Microsoft Excel (*xlsx) | *.xlsx";

            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Visible = false;

            Workbook workbook = ExcelApp.Workbooks.Add();

            for (int i = 0, n = 1; i < ServicesGrid.ColumnCount; i++, n++)
            {
                ExcelApp.Cells[1, n] = ServicesGrid.Columns[i].Name;
            }

            for (int i = 0; i < ServicesGrid.RowCount; i++)
            {
                for (int j = 0; j < ServicesGrid.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = (ServicesGrid[j, i].Value.ToString()).ToString();
                }
            }

            Worksheet worksheet = (Worksheet)ExcelApp.Worksheets[1];
            Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[ServicesGrid.RowCount + 1, ServicesGrid.ColumnCount]];

            range.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            range.Cells.VerticalAlignment = XlVAlign.xlVAlignCenter;

            range.EntireColumn.AutoFit();

            ExcelApp.Application.ActiveWorkbook.SaveAs(save.FileName);
            ExcelApp.Quit();

            MessageBox.Show("Файл сохранен", "Сохранение");
        }
    }
}
