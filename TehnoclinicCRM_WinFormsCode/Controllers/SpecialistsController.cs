using System.Data.OleDb;
using System.Data;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class SpecialistsController
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);     // Объект подключения к бд
        OleDbCommand command = new OleDbCommand();  // Объект для создания запросов на SLQ
        OleDbDataAdapter adapter = new OleDbDataAdapter();      // Объект для работы с таблицей

        DataTable table = new DataTable();  // Сохраняет в буффер (себя) ранее загруженную версию таблицы

        public DataTable UpdateTable()  // Загрузка и заполнения буффера таблицы всеми существуещими записями 
        {
            connection.Open();

            adapter = new OleDbDataAdapter("SELECT * FROM Специалисты", connection);
            table.Clear();

            adapter.Fill(table);

            connection.Close();

            return table;
        }

        public void Add(Specialist specialist)  // Добавление специалиста в таблицу
        {
            connection.Open();

            command = new OleDbCommand("INSERT INTO Специалисты (ФИО, Должность, Телефон) VALUES (@ФИО, @Должность, @Телефон)", connection);

            command.Parameters.AddWithValue("ФИО", specialist.FIO);
            command.Parameters.AddWithValue("Должность", specialist.Position);
            command.Parameters.AddWithValue("Телефон", specialist.PhoneNumber);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public Specialist Get(int id)   // Получить специалиста из базы по его идентификатору
        {
            connection.Open();

            command = new OleDbCommand("SELECT * FROM Специалисты WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("Id", id);

            OleDbDataReader reader = command.ExecuteReader();
            Specialist specialist = new Specialist();

            while (reader.Read())
            {
                specialist.FIO = reader["ФИО"].ToString();
                specialist.Position = reader["Должность"].ToString();
                specialist.PhoneNumber = reader["Телефон"].ToString();
            }

            reader.Close();
            connection.Close();

            return specialist;
        }

        public void Delete(int id)      // Удаление специалиста
        {
            connection.Open();

            command = new OleDbCommand("DELETE FROM Специалисты WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("Id", id);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Update(Specialist specialist)   // Обновление записи о специалисте
        {
            connection.Open();

            command = new OleDbCommand($"UPDATE Специалисты SET ФИО = @ФИО, Должность = @Должность, Телефон = @Телефон WHERE Id = @Id", connection);
           
            command.Parameters.AddWithValue("ФИО", specialist.FIO);
            command.Parameters.AddWithValue("Должность", specialist.Position);
            command.Parameters.AddWithValue("Телефон", specialist.PhoneNumber);
            command.Parameters.AddWithValue("Id", specialist.Id);


            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable Select(string parameter, string value)     // Выделение новой таблицы с конкретным фильтром
        {
            connection.Open();

            switch (parameter)
            {
                case "ФИО":
                    command = new OleDbCommand($"SELECT * FROM Специалисты WHERE ФИО LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);

                    break;
                case "Должность":
                    command = new OleDbCommand($"SELECT * FROM Специалисты WHERE Должность LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);

                    break;
                case "Телефон":
                    command = new OleDbCommand($"SELECT * FROM Специалисты WHERE Телефон LIKE value", connection);
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
