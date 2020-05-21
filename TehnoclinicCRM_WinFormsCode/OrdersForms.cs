using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using Excel = Microsoft.Office.Interop.Excel;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class OrdersForms : Form
    {
        private OrdersController controller = new OrdersController();
        private List<string> parametres = new List<string>();
        private List<string> values = new List<string>();
        private MenuForm form = new MenuForm();

        public OrdersForms()
        {
            InitializeComponent();

            UpdateGrid();
        }

        public OrdersForms(MenuForm owner) : base()
        {
            form = owner;
        }

        private void UpdateGrid()
        {
            OrdersGrid.DataSource = null;
            OrdersGrid.DataSource = controller.UpdateTable();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();                                   // Выход из приложения
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из приложения
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
            if (IsFramed.Checked)
            {
                if (!values.Contains("Оформлено"))
                {
                    parametres.Add("Статус");
                    values.Add("Оформлено");
                }
            }
            else
            {
                if (values.Contains("Оформлено"))
                {
                    parametres.RemoveAt(values.FindIndex(new Predicate<string>(s => s == "Оформлено")));
                    values.Remove("Оформлено");
                }
            }

            if (IsRepairs.Checked)
            {
                if (!values.Contains("Ремонт"))
                {
                    parametres.Add("Статус");
                    values.Add("Ремонт");
                }
            }
            else
            {
                if (values.Contains("Ремонт"))
                {
                    parametres.RemoveAt(values.FindIndex(new Predicate<string>(s => s == "Ремонт")));
                    values.Remove("Ремонт");
                }
            }

            if (IsClosed.Checked)
            {
                if (!values.Contains("Закрыт"))
                {
                    parametres.Add("Статус");
                    values.Add("Закрыт");
                }

            }
            else
            {
                if (values.Contains("Закрыт"))
                {
                    parametres.RemoveAt(values.FindIndex(new Predicate<string>(s => s == "Закрыт")));

                    values.Remove("Закрыт");
                }
            }

            MultiSelectEnter();
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

        private void MultiSelectEnter()
        {
            if (parametres.Count > 0)
            {
                OrdersGrid.DataSource = null;

                //// unit-test multi-select
                //MessageBox.Show(string.Join(" ; ", parametres.ToArray()));
                //MessageBox.Show(string.Join(" ; ", values.ToArray()));

                OrdersGrid.DataSource = controller.MultiSelect(parametres, values);
            }
            else
            {
                UpdateGrid();
            }
        }

        private void SumSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SumSearch.Text))
            {
                if (!parametres.Contains("Итоговая_сумма"))
                {
                    parametres.Add("Итоговая_сумма");
                    values.Add(SumSearch.Text);
                }
                else
                {
                    values.RemoveAt(parametres.FindIndex(new Predicate<string>(p => p == "Итоговая_сумма")));
                    parametres.Remove("Итоговая_сумма");

                    parametres.Add("Итоговая_сумма");
                    values.Add(SumSearch.Text);
                }
            }
            else
            {
                if (parametres.Contains("Итоговая_сумма"))
                {
                    values.RemoveAt(parametres.FindIndex(new Predicate<string>(p => p == "Итоговая_сумма")));
                    parametres.Remove("Итоговая_сумма");
                }
            }

            MultiSelectEnter();
        }

        private void DateEndSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DateEndSearch.Text))
            {
                if (!parametres.Contains("Дата_окончания_выполнения"))
                {
                    parametres.Add("Дата_окончания_выполнения");
                    values.Add(DateEndSearch.Text);
                }
                else
                {
                    values.RemoveAt(parametres.FindIndex(new Predicate<string>(p => p == "Дата_окончания_выполнения")));
                    parametres.Remove("Дата_окончания_выполнения");

                    parametres.Add("Дата_окончания_выполнения");
                    values.Add(DateEndSearch.Text);
                }
            }
            else
            {
                if (parametres.Contains("Дата_окончания_выполнения"))
                {
                    values.RemoveAt(parametres.FindIndex(new Predicate<string>(p => p == "Дата_окончания_выполнения")));
                    parametres.Remove("Дата_окончания_выполнения");
                }
            }

            MultiSelectEnter();
        }

        private void ResetMulty_Click(object sender, EventArgs e)
        {
            IsFramed.Checked = false;
            IsRepairs.Checked = false;
            IsClosed.Checked = false;

            SumSearch.Text = null;
            DateEndSearch.Text = null;
        }
    }
}
