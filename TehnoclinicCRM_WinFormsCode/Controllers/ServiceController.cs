using System.Data;
using System.Data.OleDb;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class ServiceController
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);        // Объект для подключения к БД
        OleDbCommand command = new OleDbCommand();  // Объект для управления запросами SQL
        OleDbDataAdapter adapter = new OleDbDataAdapter();  // Работа с таблицей БД

        public DataTable table = new DataTable();  // Буффер таблицы

        public DataTable UpdateTable()
        {
            connection.Open();

            adapter = new OleDbDataAdapter("SELECT Услуги.Id,Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код", connection);

            table.Clear();
            adapter.Fill(table);

            connection.Close();

            return table;
        }

        public Service Get(int id)   // Получить специалиста из базы по его идентификатору
        {
            connection.Open();

            command = new OleDbCommand("SELECT * FROM Услуги WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("Id", id);

            OleDbDataReader reader = command.ExecuteReader();
            Service service = new Service();

            while (reader.Read())
            {
                service.Id = int.Parse(reader["Id"].ToString());
                service.Name = reader["Название_услуги"].ToString();
                service.Price = double.Parse(reader["Цена"].ToString());
                service.Subdivision = int.Parse(reader["Подразделение"].ToString());
            }

            reader.Close();
            connection.Close();

            return service;
        }

        public DataTable Select(string parameter, string value)     // Выделение новой таблицы с конкретным фильтром
        {
            connection.Open();

            value = "%" + value + "%";

            switch (parameter)
            {
                case "Подразделение":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код) WHERE Подразделение LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Услуга":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код) WHERE Услуга LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Цена":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код) WHERE Цена LIKE value", connection);
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

        // Выборка услуг только по поздраделению
        public DataTable SelectServices(string subdivision)
        {
            connection.Open();

            subdivision = "%" + subdivision + "%";

            command = new OleDbCommand($"SELECT * FROM (SELECT Услуги.Id, Подразделения.Код AS Код_подразделения, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код) WHERE Подразделение LIKE subdiv", connection);
            command.Parameters.AddWithValue("subdiv", subdivision);

            OleDbDataAdapter tempAdapter = new OleDbDataAdapter(command);
            DataTable tempTable = new DataTable();

            tempAdapter.Fill(tempTable);

            connection.Close();

            return tempTable;
        }

    }
}
