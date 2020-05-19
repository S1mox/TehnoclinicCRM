using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class ClientsForm : Form
    {
        ClientsController controller = new ClientsController();     // Контроллер для работы с таблицей клиентов

        public ClientsForm()
        {
            InitializeComponent();

            UpdateGrid();   // Обновление таблиц на форме
        }

        private void UpdateGrid()
        {
            try
            {
                ClientsGrid.DataSource = null;
                ClientsGrid.DataSource = controller.UpdateTable();
                ClientsGrid.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из формы
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Add(new Client() { FIO = FIO.Text, PhoneNumber = PhoneNumber.Text, Passport = Passport.Text });       // Добавление записи через контроллер

                UpdateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                throw;
            }           
        }

        private void Get_Click(object sender, EventArgs e)
        {
            if (ClientsGrid.CurrentRow != null)
            {
                Client currentClient = controller.Get(int.Parse(ClientsGrid.CurrentRow.Cells["Id"].Value.ToString()));      // Берем экземпляр клиента из базы по его Id

                ClientEdit.Text = currentClient.FIO;
                PassportEdit.Text = currentClient.Passport;
                PhoneNumberEdit.Text = currentClient.PhoneNumber;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                controller.Delete(int.Parse(ClientsGrid.CurrentRow.Cells["Id"].Value.ToString()));               // Удаление из таблицы БД по его идентификатору
            }

            UpdateGrid();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Client client = new Client()                                        // Создаем экземпляр специалиста из выбранной ячейки
            {
                Id = int.Parse(ClientsGrid.CurrentRow.Cells["Id"].Value.ToString()),
                FIO = ClientEdit.Text,
                Passport = PassportEdit.Text,
                PhoneNumber = PhoneNumberEdit.Text
            };

            MessageBox.Show(client.ToString());

            controller.Update(client);

            UpdateGrid();
        }

        private void Reset_Click(object sender, EventArgs e)
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
                    ClientsGrid.DataSource = null;
                    ClientsGrid.DataSource = controller.Select(CriteriesBox.SelectedItem.ToString(), SearchText.Text);

                    ClientsGrid.Columns["Id"].Visible = false;
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

 


        private void специалистыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpecialistsForm().Show();
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
            save.FileName = $"Отчет по клиентам за {DateTime.Now.ToShortDateString()}";
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

            for (int i = 0, n = 1; i < ClientsGrid.ColumnCount; i++, n++)
            {
                ExcelApp.Cells[1, n] = ClientsGrid.Columns[i].Name;
            }

            for (int i = 0; i < ClientsGrid.RowCount; i++)
            {
                for (int j = 0; j < ClientsGrid.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = (ClientsGrid[j, i].Value.ToString()).ToString();
                }
            }

            Worksheet worksheet = (Worksheet)ExcelApp.Worksheets[1];
            Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[ClientsGrid.RowCount + 1, ClientsGrid.ColumnCount]];

            range.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            range.Cells.VerticalAlignment = XlVAlign.xlVAlignCenter;

            range.EntireColumn.AutoFit();

            ExcelApp.Application.ActiveWorkbook.SaveAs(save.FileName);
            ExcelApp.Quit();

            MessageBox.Show("Файл сохранен", "Сохранение");
        }
    }
}
