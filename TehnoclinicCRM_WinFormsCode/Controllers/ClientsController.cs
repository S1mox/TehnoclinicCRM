using System.Data.OleDb;
using System.Data;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class ClientsController
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);        // Объект для подключения к БД
        OleDbCommand command = new OleDbCommand();  // Объект для управления запросами SQL
        OleDbDataAdapter adapter = new OleDbDataAdapter();  // Работа с таблицей БД

        DataTable table = new DataTable();  // Буффер таблицы

        public DataTable UpdateTable()  // Заполнение буффера
        {
            connection.Open();

            adapter = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);
            table.Clear();

            adapter.Fill(table);

            connection.Close();

            return table;
        }

        public void Add(Client client)  // Добавление клиента
        {
            connection.Open();

            command = new OleDbCommand("INSERT INTO Клиенты (ФИО, Паспортные_данные, Номер_телефона) VALUES (@ФИО, @Паспортные_данные, @Номер_телефона)", connection);

            command.Parameters.AddWithValue("ФИО", client.FIO);
            command.Parameters.AddWithValue("Паспортные_данные", client.Passport);
            command.Parameters.AddWithValue("Номер_телефона", client.PhoneNumber);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public Client Get(int id)   // Получить клиента по его идентификатору
        {
            connection.Open();

            command = new OleDbCommand("SELECT * FROM Клиенты WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("Id", id);

            OleDbDataReader reader = command.ExecuteReader();
            Client client = new Client();

            while (reader.Read())
            {
                client.FIO = reader["ФИО"].ToString();
                client.Passport = reader["Паспортные_данные"].ToString();
                client.PhoneNumber = reader["Номер_телефона"].ToString();
            }

            reader.Close();
            connection.Close();

            return client;
        }

        public void Delete(int id)  // Удаление клиента по идентификатору
        {
            connection.Open();

            command = new OleDbCommand("DELETE FROM Клиенты WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("Id", id);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Update(Client client)   // Обновление записи о клиенте
        {
            connection.Open();

            command = new OleDbCommand("UPDATE Клиенты SET ФИО = @ФИО, Паспортные_данные = @Паспортные_данные, Номер_телефона = @Номер_телефона WHERE Id = @Id", connection);

            command.Parameters.AddWithValue("ФИО", client.FIO);
            command.Parameters.AddWithValue("Паспортные_данные", client.Passport);
            command.Parameters.AddWithValue("Номер_телефона", client.PhoneNumber);
            command.Parameters.AddWithValue("Id", client.Id);


            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable Select(string parameter, string value) // вернуть новую таблицу по заданному фильтру
        {
            connection.Open();

            switch (parameter)
            {
                case "ФИО":
                    command = new OleDbCommand($"SELECT * FROM Клиенты WHERE ФИО LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);

                    break;
                case "Паспортные_данные":
                    command = new OleDbCommand($"SELECT * FROM Клиенты WHERE Паспортные данные LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);

                    break;
                case "Номер_телефона":
                    command = new OleDbCommand($"SELECT * FROM Клиенты WHERE Номер телефона LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);

                    break;
                default:
                    break;
            }


            OleDbDataAdapter tempAdapter = new OleDbDataAdapter(command);
            DataTable tempTable = new DataTable();

            tempAdapter.Fill(tempTable);

            connection.Close();

            return tempTable;
        }
    }
}
