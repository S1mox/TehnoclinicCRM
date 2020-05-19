using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class SpecialistsForm : Form
    {
        SpecialistsController controller = new SpecialistsController();     // Контроллер для работы с таблице специалистов

        public SpecialistsForm()
        {
            InitializeComponent();

            UpdateGrid();   // Обновление таблицы на форме
        }

        private void Add_Click(object sender, EventArgs e)
        {
            controller.Add(new Specialist() { FIO = FIO.Text, PhoneNumber = PhoneNumber.Text, Position = Position.Text });       // Добавление записи через контроллер

            UpdateGrid();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            if (SpecialistGrid.CurrentRow != null)
            {
                Specialist currentSpecialist = controller.Get(int.Parse(SpecialistGrid.CurrentRow.Cells["Id"].Value.ToString()));      // Берем экземпляр специалиста из базы по его Id

                SpecialistEdit.Text = currentSpecialist.FIO;
                PositionEdit.Text = currentSpecialist.Position;
                PhoneNumberEdit.Text = currentSpecialist.PhoneNumber;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из приложения
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                controller.Delete(int.Parse(SpecialistGrid.CurrentRow.Cells["Id"].Value.ToString()));               // Удаление из таблицы БД по его идентификатору
            }

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            SpecialistGrid.DataSource = null;
            SpecialistGrid.DataSource = controller.UpdateTable();
            SpecialistGrid.Columns["Id"].Visible = false;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Specialist specialist = new Specialist()                                        // Создаем экземпляр специалиста из выбранной ячейки
            {
                Id = int.Parse(SpecialistGrid.CurrentRow.Cells["Id"].Value.ToString()),
                FIO = SpecialistEdit.Text,
                Position = PositionEdit.Text,
                PhoneNumber = PhoneNumberEdit.Text
            };

            MessageBox.Show(specialist.ToString());

            controller.Update(specialist);

            UpdateGrid();
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)        // Сброс поиска
        {
            CriteriesBox.SelectedIndex = 0;
            SearchText.Text = "";
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (SearchText != null && SearchText.Text.Length > 0 && CriteriesBox.SelectedItem != null)
            {
                try
                {
                    SpecialistGrid.DataSource = null;
                    SpecialistGrid.DataSource = controller.Select(CriteriesBox.SelectedItem.ToString(), SearchText.Text);       // создаем новую таблицу из найденных записей

                    SpecialistGrid.Columns["Id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                UpdateGrid();
            }
        }

        public void AddOrder_Click(object sender, EventArgs e)
        {
            new AddOrderForm().Show();
        }



        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientsForm().Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServicesForm().Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdersForms().Show();
        }

        private void Create_ExcelReport(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = $"Отчет по специалистам за {DateTime.Now.ToShortDateString()}";
            save.DefaultExt = "xlsx";
            save.AddExtension = true;
            save.Filter = "Лист Microsoft Excel (*xlsx) | *.xlsx";

            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Visible = false;

            Workbook workbook =  ExcelApp.Workbooks.Add();

            for (int i = 0, n = 1; i < SpecialistGrid.ColumnCount; i++, n++)
            {
                ExcelApp.Cells[1, n] = SpecialistGrid.Columns[i].Name;
            }

            for (int i = 0; i < SpecialistGrid.RowCount; i++)
            {
                for (int j = 0; j < SpecialistGrid.ColumnCount; j++)
                {
                    ExcelApp.Cells[i+2, j + 1] = (SpecialistGrid[j, i].Value.ToString()).ToString();
                }
            }

            Worksheet worksheet = (Worksheet)ExcelApp.Worksheets[1];
            Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[SpecialistGrid.RowCount + 1, SpecialistGrid.ColumnCount]];

            range.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            range.Cells.VerticalAlignment = XlVAlign.xlVAlignCenter;

            range.EntireColumn.AutoFit();

            ExcelApp.Application.ActiveWorkbook.SaveAs(save.FileName);
            ExcelApp.Quit();

            MessageBox.Show("Файл сохранен", "Сохранение");
        }
    }
}
