using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class SpecialistsController
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);     // Объект подключения к бд
        OleDbCommand command = new OleDbCommand();  // Объект для создания запросов на SLQ
        OleDbDataAdapter adapter = new OleDbDataAdapter();      // Объект для работы с таблицей

        public DataTable table = new DataTable();  // Сохраняет в буффер (себя) ранее загруженную версию таблицы

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
                specialist.Id = int.Parse(reader["Id"].ToString());
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

            value = "%" + value + "%";

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

        // Метод для создания таблицы, исходя из нескольких параметров
        public DataTable MultiSelect(List<string> parametres, List<string> values)
        {
            if (parametres.Count >= 1) //  в случае, если параметров нет, возвращаем таблицу без фильтрации
            {
                try
                {
                    connection.Open();

                    List<char> symbols = new List<char>() { '-', '!', ',', '.', '?', '\'', '/', '/', '(', ')', '*', '%', '+', '=', '&', '^', ':', ';', '#', '№', '@', '"', '`', '~', '<', '>', '|', '[', ']', '{', '}' };

                    for (int i = 0; i < symbols.Count; i++)
                    {
                        if (values[0].Contains(symbols[i].ToString()))
                        {
                            values[0] = values[0].Replace(symbols[i], '_');
                        }
                    }

                    // Создание фильтра
                    string query = " WHERE ";
                    query += $" {parametres[0]} LIKE {values[0]}";

                    for (int i = 1; i < parametres.Count; i++)
                    {

                        for (int j = 0; j < symbols.Count; j++)
                        {
                            if (values[i].Contains(symbols[j].ToString()))
                            {
                                values[i] = values[i].Replace(symbols[j], '_');
                            }
                        }

                        query += $" AND {parametres[i]} LIKE {values[i]}";
                    }

                    // Создание команды
                    command = new OleDbCommand("SELECT * FROM Специалисты" + query, connection);

                    for (int i = 0; i < parametres.Count; i++)
                    {
                        string tempvalue = $"%{values[i]}%";
                        command.Parameters.AddWithValue($"{values[i]}", tempvalue);
                    }

                    // Заполнение адаптера
                    OleDbDataAdapter tempAdapter = new OleDbDataAdapter(command);
                    DataTable tempTable = new DataTable();

                    tempAdapter.Fill(tempTable);

                    connection.Close();

                    return tempTable;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + "  | " + command.CommandText);
                }
            }
            else
            {
                return UpdateTable();
            }

            return null;
        }
    }
}
