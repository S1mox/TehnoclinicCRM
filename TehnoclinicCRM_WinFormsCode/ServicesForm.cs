using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;
using System.Data.OleDb;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class ServicesForm : Form
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);        // Объект для подключения к БД
        OleDbCommand command = new OleDbCommand();  // Объект для управления запросами SQL
        OleDbDataAdapter adapter = new OleDbDataAdapter();  // Работа с таблицей БД

        DataTable table = new DataTable();  // Буффер таблицы

        public ServicesForm()
        {
            InitializeComponent();

            UpdateTable();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();                                   // Выход из формы
        }

        private void UpdateTable()
        {
            connection.Open();

            adapter = new OleDbDataAdapter("SELECT Подразделения.Тип AS Подразделение, Услуги.Название_услуги AS Услуга, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код", connection);

            table.Clear();
            adapter.Fill(table);

            ServicesGrid.DataSource = table;

            connection.Close();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            if (SearchText != null && SearchText.Text.Length > 0 && CriteriesBox.SelectedItem != null)
            {
                try
                {
                    switch (CriteriesBox.SelectedItem.ToString())
                    {
                        case "Подразделение":
                            ServicesGrid.DataSource = null;
                            ServicesGrid.DataSource = Select("Подразделение", SearchText.Text);

                            break;

                        case "Услуга":
                            break;

                        case "Цена":


                            break;

                        default:
                            break;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                UpdateTable();
            }
        }

        public DataTable Select(string parameter, string value)     // Выделение новой таблицы с конкретным фильтром
        {
            connection.Open();

            value += "%";

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
    }
}
