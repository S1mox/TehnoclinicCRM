using System;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;

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
            ClientsGrid.DataSource = null;
            ClientsGrid.DataSource = controller.UpdateTable();
            ClientsGrid.Columns["Id"].Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из формы
        }

        private void Add_Click(object sender, EventArgs e)
        {
            controller.Add(new Client() { FIO = FIO.Text, PhoneNumber = PhoneNumber.Text, Passport = Passport.Text });       // Добавление записи через контроллер

            UpdateGrid();
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

        public void Dictionary_Click(object senderm, EventArgs e)
        {
            new DirectoryForm().Show();
        }
    }
}
