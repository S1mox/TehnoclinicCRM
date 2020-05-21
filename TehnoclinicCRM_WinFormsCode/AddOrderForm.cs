using System;
using System.Data;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class AddOrderForm : Form
    {
        OrdersController OrdersController = new OrdersController();                     // Контроллер для обработки заказов
        ClientsController ClientsController = new ClientsController();                  // Контроллер для обработки клиентов
        SpecialistsController SpecialistsController = new SpecialistsController();      // Контроллер для обработки специалистов
        ServiceController ServicesController = new ServiceController();                 // Контроллер для обработки услуг
        SubdivisionsController SubdivisionsController = new SubdivisionsController();   // Контроллер для обработки типов подразделений

        ParserToModel parser = new ParserToModel();         // Парсер из строк таблицы в целые объекты (клиенты, специалисты, услуги, подразделения)

        Client CurrentClient = new Client();                // Текущий выбранный клиент
        Specialist CurrentSpecialist = new Specialist();    // Текущий выбранный специалист
        Service CurrentService = new Service();             // Текущая выбранная услуга

        public AddOrderForm()
        {
            InitializeComponent();

            OrdersController.UpdateTable();

            CurrentTime.Format = DateTimePickerFormat.Custom;
            CurrentTime.CustomFormat = "MM/dd/yyyy HH:mm tt";       // Передача формата даты:времени в часы

            DateOfReceiveDP.Value = DateTime.Now;       // задаем текущую дату в поля с датами
            DateOfBeginEdit.Value = DateTime.Now;
            DateOfEndEdit.Value = DateTime.Now;

            // Обновление клиентов, специалистов, подразделений 
            UpdateClients();
            UpdateSpecialists();
            UpdateSubdivisions(null, null);
        }

        private void CurrentTimeTicker_Tick(object sender, EventArgs e)
        {
            CurrentTime.Value = DateTime.Now;                           // Часы в левой нижней части экрана обновляются каждые 1000 мс
        }

        // Добавляет в комбобокс с клиентами всех клиентов
        private void UpdateClients()
        {
            DataTable temp = ClientsController.UpdateTable();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                ClientsBox.Items.Add(parser.GetClient(temp.Rows[i]));       // Добавление в комбобокс полного объекта (не только ФИО)
            }
        }

        // Добавляет в комбобокс с специалистами всех специалистов
        private void UpdateSpecialists()
        {
            DataTable temp = SpecialistsController.UpdateTable();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                SpecialistsBox.Items.Add(parser.GetSpecialist(temp.Rows[i])); // Добавление в комбобокс полного объекта (не только ФИО)
            }
        }


        // Добавляет в комбобокс с подразделениями всех подразделений и в связке 
        //  выбранными подразделениями выбирает услуги
        public void UpdateSubdivisions(object sender, EventArgs e)
        {
            SubdivisionsBox.Items.Clear();

            DataTable temp = SubdivisionsController.UpdateTable();

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                SubdivisionsBox.Items.Add(parser.GetSubdivision(temp.Rows[i])); // Добавление в комбобокс полного объекта (не только ФИО)
            }

            UpdateServices(null, null);
        }

        // Добавляет услуги, содержащие в себе выбранное подразделение,
        // либо без этой фильтрации, если подразделение не выбрано
        private void UpdateServices(object sender, EventArgs e)
        {
            PriceBox.Text = "";
            ServicesBox.Items.Clear();  // Очищает старый фильтр услуг
            ServicesBox.SelectedItem = null;

            if (SubdivisionsBox.SelectedItem != null)
            {
                DataTable temp = ServicesController.SelectServices(SubdivisionsBox.SelectedItem.ToString());

                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    ServicesBox.Items.Add(parser.GetService(temp.Rows[i]));
                }
            }
            else
            {
                DataTable temp = ServicesController.SelectServices("");

                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    ServicesBox.Items.Add(parser.GetService(temp.Rows[i]));
                }
            }
        }

        // Собирает в новый текущий экземпляр клиента, если пользователь выбирает клиента из списка
        private void ClientsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientsBox.SelectedItem != null)
            {
                CurrentClient = ClientsController.Get(((Client)ClientsBox.SelectedItem).Id);      // Берем экземпляр клиента из базы по его Id

                ClientEdit.Text = CurrentClient.FIO;
                PassportEdit.Text = CurrentClient.Passport;
                PhoneNumberEdit.Text = CurrentClient.PhoneNumber;
            }
        }

        // Собирает в новый текущий экземпляр специалиста, если пользователь выбирает специалиста из списка
        private void SpecialistsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientsBox.SelectedItem != null)
            {
                CurrentSpecialist = SpecialistsController.Get(((Specialist)SpecialistsBox.SelectedItem).Id);      // Берем экземпляр клиента из базы по его Id

                FIOSpEdit.Text = CurrentSpecialist.FIO;
                PositionEdit.Text = CurrentSpecialist.Position;
                PhoneNumberSpEdit.Text = CurrentSpecialist.PhoneNumber;
            }
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            new ClientsForm().Show();
        }

        private void Specialists_Click(object sender, EventArgs e)
        {
            new SpecialistsForm().Show();
        }

        // Собирает в новый текущий экземпляр услуги, если пользователь выбирает услугу из списка
        private void ServicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicesBox.SelectedItem != null)
            {
                CurrentService = ServicesController.Get(((Service)ServicesBox.SelectedItem).Id);

                PriceBox.Text = CurrentService.Price.ToString();
            }
        }

        private void Services_Click(object sender, EventArgs e)
        {
            new ServicesForm().Show();
        }

        // Очищение всех полей по кнопке сброса
        private void Reset_Click(object sender, EventArgs e)
        {
            ClientsBox.SelectedItem = null;
            SpecialistsBox.SelectedItem = null;
            ServicesBox.SelectedItem = null;
            StatusEdit.SelectedItem = null;
            SubdivisionsBox.SelectedItem = null;

            DateOfReceiveDP.Value = DateTime.Now;
            DateOfBeginEdit.Value = DateTime.Now;
            DateOfEndEdit.Value = DateTime.Now;

            SumEdit.Text = null;
            PriceBox.Text = null;
            PriceBox.Text = null;
            FIOSpEdit.Text = null;
            PositionEdit.Text = null;
            PhoneNumberSpEdit.Text = null;
            ClientEdit.Text = null;
            PassportEdit.Text = null;
            PhoneNumberEdit.Text = null;
        }

        // Попытка добавить запись, в противном случае генерация исключения
        private void Add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateOfReceiveDP.Value.ToString()); // debug

            try
            {
                OrdersController.Add(new Order()
                {
                    DateOfReceiving = DateOfReceiveDP.Value.ToString(),
                    NumberOfOrder = int.Parse(OrdersController.table.Rows[OrdersController.table.Rows.Count - 1][0].ToString()) + 1, // Дебаг версия
                    Client = CurrentClient,
                    Service = CurrentService,
                    Specialist = CurrentSpecialist,
                    DateOfBegin = DateOfBeginEdit.Value.ToString(),
                    DateOfEnd = DateOfEndEdit.Value.ToString(),
                    Sum = double.TryParse(SumEdit.Text, out double sum) ? sum : CurrentService.Price, // если итоговая ценна не введена, тогда берем цену услуги
                    Status = StatusEdit.SelectedIndex + 1 // Дебаг версия
                });

                MessageBox.Show("Запись была добавлена", "Добавление");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
