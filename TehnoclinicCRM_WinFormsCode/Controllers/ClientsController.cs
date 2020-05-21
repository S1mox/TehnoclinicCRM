using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class ClientsController
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);        // Объект для подключения к БД
        OleDbCommand command = new OleDbCommand();  // Объект для управления запросами SQL
        OleDbDataAdapter adapter = new OleDbDataAdapter();  // Работа с таблицей БД

        public DataTable table = new DataTable();  // Буффер таблицы

        public DataTable UpdateTable()  // Заполнение буффера
        {
            connection.Open();

            adapter = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);        // выборка всех столбцов из БД
            table.Clear();

            adapter.Fill(table);

            connection.Close();

            return table;
        }

        public void Add(Client client)  // Добавление клиента
        {
            connection.Open();

            /*
             * Вставляем в таблицу экземпляр класса Клиент
             */
            command = new OleDbCommand("INSERT INTO Клиенты (ФИО, Паспортные_данные, Номер_телефона) VALUES (@ФИО, @Паспортные_данные, @Номер_телефона)", connection);


            // параметры к запросу
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

            while (reader.Read())   // Пока не прочитаются все записи из выборки для чтения
            {
                client.Id = int.Parse(reader["Id"].ToString());
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

            command = new OleDbCommand("DELETE FROM Клиенты WHERE Id = @Id", connection);       // удаление записи, чей идентификатор равен заявленному в параметрах метода
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

            List<char> symbols = new List<char>() { '-', '!', ',', '.', '?', '\'', '/', '/', '(', ')', '*', '%', '+', '=', '&', '^', ':', ';', '#', '№', '@', '"', '`', '~', '<', '>', '|', '[', ']', '{', '}' };

            for (int i = 0; i < symbols.Count; i++)
            {
                if (value.Contains(symbols[i].ToString()))
                {
                    value = value.Replace(symbols[i], '_');
                }
            }

            value = "%" + value + "%";      // означает, что в конструкции LIKE будут отфильтрованны данные к тем, которые содержат в себе некоторое value

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
                    command = new OleDbCommand("SELECT * FROM Клиенты" + query, connection);

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
