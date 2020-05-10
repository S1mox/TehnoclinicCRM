using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void VisitSite_Click(object sender, EventArgs e)
        {
            Process.Start("https://tehnoclinic.by/");               // Переход по ссылке на главную страницу сайта ТехноКлиники
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();                                     // Выход из приложения
        }

        private void Specialists_Click(object sender, EventArgs e)
        {
            new SpecialistsForm().Show();                           // Показать форму просмотра справочника специалистов
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            new ClientsForm().Show();                               // Показать форму справочника клиентов
        }

        private void Services_Click(object sender, EventArgs e)
        {
            new ServicesForm().Show();                              // Показать форму услуг
        }

        private void FormedOrders_Click(object sender, EventArgs e)
        {
            new OrdersForms().Show();                               // Показать форму оформленных заказов
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            new AddOrderForm().Show();                              // Показать форму формирования заказа
        }
    }
}
