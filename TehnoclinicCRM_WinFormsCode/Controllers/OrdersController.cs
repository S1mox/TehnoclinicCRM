﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using TehnoclinicCRM_WinFormsCode.Models;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class OrdersController
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);     // Объект подключения к бд
        OleDbCommand command = new OleDbCommand();  // Объект для создания запросов на SLQ
        OleDbDataAdapter adapter = new OleDbDataAdapter();      // Объект для работы с таблицей

        public DataTable table = new DataTable();  // Сохраняет в буффер (себя) ранее загруженную версию таблицы

        public DataTable UpdateTable()  // Загрузка и заполнения буффера таблицы всеми существуещими записями 
        {
            connection.Open();

            adapter = new OleDbDataAdapter("SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение", connection);
            table.Clear();

            adapter.Fill(table);

            connection.Close();

            return table;
        }

        public void Add(Order order)  // Добавление специалиста в таблицу
        {
            connection.Open();

            command = new OleDbCommand("INSERT INTO Заказы (Номер_заказа, Дата_получения, Клиент, Услуга, Специалист, Дата_начала_выполнения, Дата_окончания_выполнения, Итоговая_сумма, Статус_выполнения) VALUES (Номер_заказа, Дата_получения, Клиент, Услуга, Специалист, Дата_начала_выполнения, Дата_окончания_выполнения, Итоговая_сумма, Статус_выполнения)", connection);

            command.Parameters.AddWithValue("Номер_заказа", order.NumberOfOrder);
            command.Parameters.AddWithValue("Дата_получения", order.DateOfReceiving);
            command.Parameters.AddWithValue("Клиент", order.Client.Id);
            command.Parameters.AddWithValue("Услуга", order.Service.Id);
            command.Parameters.AddWithValue("Специалист", order.Specialist.Id);
            command.Parameters.AddWithValue("Дата_начала_выполнения", order.DateOfBegin);
            command.Parameters.AddWithValue("Дата_окончания_выполнения", order.DateOfEnd);
            command.Parameters.AddWithValue("Итоговая_сумма", order.Sum);
            command.Parameters.AddWithValue("Статус_выполнения", order.Status);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(int id)      // Удаление специалиста
        {
            connection.Open();

            command = new OleDbCommand("DELETE FROM Заказы WHERE Номер_заказа = @Id", connection);
            command.Parameters.AddWithValue("Id", id);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable Select(string parameter, string value)     // Выделение новой таблицы с конкретным фильтром
        {
            connection.Open();

            value = "%" + value + "%";

            switch (parameter)
            {
                case "Номер_заказа":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Номер_заказа LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Дата_получения":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Дата_получения LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Клиент":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Клиент LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Подразделение":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Подразделение LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;


                case "Услуга":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Услуга LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Предварительная_цена":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Предварительная_цена LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Специалист":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Специалист LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Дата_начала_выполнения":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Дата_начала_выполнения LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Дата_окончания_выполнения":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Дата_окончания_выполнения LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Итоговая_сумма":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Итоговая_сумма LIKE value", connection);
                    command.Parameters.AddWithValue("value", value);
                    break;

                case "Статус":
                    command = new OleDbCommand($"SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " +
                "WHERE Статус LIKE value", connection);
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
                    string query = "WHERE ";
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
                    command = new OleDbCommand("SELECT * FROM (SELECT Заказы.[Номер_заказа], Заказы.[Дата_получения], Клиенты.ФИО AS Клиент, Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена AS Предварительная_Цена, Специалисты.ФИО AS Специалист, Заказы.Дата_начала_выполнения, Заказы.Дата_окончания_выполнения, Заказы.Итоговая_сумма, Статусы_выполнения.Статус " +
                    "FROM Подразделения INNER JOIN(Статусы_выполнения INNER JOIN(Услуги INNER JOIN(Специалисты INNER JOIN(Клиенты INNER JOIN Заказы ON Клиенты.Id = Заказы.Клиент) ON Специалисты.Id = Заказы.Специалист) ON Услуги.Id = Заказы.Услуга) ON(Статусы_выполнения.Код = Заказы.Статус_выполнения) AND(Статусы_выполнения.Код = Заказы.Статус_выполнения)) ON Подразделения.Код = Услуги.Подразделение) " + query, connection);

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
                UpdateTable();
            }

            return null;
        }
    }
}

