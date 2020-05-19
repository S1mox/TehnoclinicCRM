using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Data = System.Data;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class OrdersForms : Form
    {
        private OrdersController controller = new OrdersController();

        public OrdersForms()
        {
            InitializeComponent();

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            OrdersGrid.DataSource = null;
            OrdersGrid.DataSource = controller.UpdateTable();
            OrdersGrid.AutoResizeColumns();

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из приложения
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {

        }

        public void AddOrder_Click(object sender, EventArgs e)
        {
            new AddOrderForm().Show();
        }



        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                controller.Delete(int.Parse(OrdersGrid.CurrentRow.Cells["Номер_заказа"].Value.ToString()));               // Удаление из таблицы БД по его идентификатору
            }
            else
            {
                UpdateGrid();
            }
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (SearchText != null && SearchText.Text.Length > 0 && CriteriesBox.SelectedItem != null)
            {
                OrdersGrid.DataSource = null;
                OrdersGrid.DataSource = controller.Select(CriteriesBox.SelectedItem.ToString().Replace(" ", "_"), SearchText.Text);
            }
            else
            {
                UpdateGrid();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            SearchText.Text = null;
            CriteriesBox.SelectedItem = null;
        }

        private void IsFramed_CheckedChanged(object sender, EventArgs e)
        {
            Data.DataTable table = controller.table.Copy();
            table.Clear();


            if (IsFramed.Checked)
            {
                Data.DataTable Framed = new Data.DataTable();

                Framed = controller.Select("Статус", "Оформлен");
                table.Merge(Framed);
            }

            if (IsRepairs.Checked)
            {
                Data.DataTable Repairs = new Data.DataTable();

                Repairs = controller.Select("Статус", "Ремонт");
                table.Merge(Repairs);
            }

            if (IsClosed.Checked)
            {
                Data.DataTable Closed = new Data.DataTable();

                Closed = controller.Select("Статус", "Закрыт");
                table.Merge(Closed);
            }

            if (!IsFramed.Checked && !IsRepairs.Checked && !IsClosed.Checked)
            {
                UpdateGrid();
                return;
            }

            OrdersGrid.DataSource = null;
            OrdersGrid.DataSource = table;
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientsForm().Show();
        }

        private void специалистыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpecialistsForm().Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServicesForm().Show();
        }

        private void Create_ExcelReport(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = $"Отчет по заказам за {DateTime.Now.ToShortDateString()}";
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

            for (int i = 0, n = 1; i < OrdersGrid.ColumnCount; i++, n++)
            {
                ExcelApp.Cells[1, n] = OrdersGrid.Columns[i].Name;
            }

            for (int i = 0; i < OrdersGrid.RowCount; i++)
            {
                for (int j = 0; j < OrdersGrid.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = (OrdersGrid[j, i].Value.ToString()).ToString();
                }
            }

            Worksheet worksheet = (Worksheet)ExcelApp.Worksheets[1];
            Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[OrdersGrid.RowCount + 1, OrdersGrid.ColumnCount]];

            range.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            range.Cells.VerticalAlignment = XlVAlign.xlVAlignCenter;

            range.EntireColumn.AutoFit();

            ExcelApp.Application.ActiveWorkbook.SaveAs(save.FileName);
            ExcelApp.Quit();

            MessageBox.Show("Файл сохранен", "Сохранение");
        }
    }
}
