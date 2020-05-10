using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;
using System;

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
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                controller.Delete(int.Parse(OrdersGrid.CurrentRow.Cells["Номер_заказа"].Value.ToString()));               // Удаление из таблицы БД по его идентификатору
            }

            UpdateGrid();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (SearchText != null && SearchText.Text.Length > 0 && CriteriesBox.SelectedItem != null)
            {
                for (int i = 0; i < OrdersGrid.Rows.Count; i++)
                {
                   
                }
            }
        }
    }
}
