using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using TehnoclinicCRM_WinFormsCode.Controllers;
using TehnoclinicCRM_WinFormsCode.Models;
using System.Collections.Generic;

namespace TehnoclinicCRM_WinFormsCode
{
    public partial class DirectoryForm : Form
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);        // Объект для подключения к БД
        OleDbCommand command = new OleDbCommand();  // Объект для управления запросами SQL
        OleDbDataAdapter adapter = new OleDbDataAdapter();  // Работа с таблицей БД

        DataTable table = new DataTable();  // Буффер таблицы

        public DirectoryForm()
        {
            InitializeComponent();

            SetTree();
        }

        private void SetTree()
        {
            connection.Open();

            Tree.Nodes.Add("Услуги");

            command = new OleDbCommand("SELECT Подразделения.Тип AS Подразделение, Услуги.Название_услуги, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код", connection);

            //adapter = new OleDbDataAdapter("SELECT Подразделения.Тип AS Подразделение, Услуги.Название_услуги, Услуги.Цена FROM Услуги, Подразделения WHERE Услуги.Подразделение = Подразделения.Код", connection);
            //table.Clear();
            //adapter.Fill(table);                          // отладка создания таблицы услуг с данными из справочника
            //dataGridView1.DataSource = table;

            OleDbDataReader reader = command.ExecuteReader();
            Client client = new Client();

            List<string> pastUnits = new List<string>();

            while (reader.Read())
            {
                TreeNode node = new TreeNode(reader["Название_услуги"].ToString());

                string nodeName = reader["Подразделение"].ToString();

                if (!pastUnits.Contains(nodeName))
                {
                    Tree.Nodes[0].Nodes.Add(nodeName);

                    for (int i = 0; i < Tree.Nodes[0].Nodes.Count; i++)
                    {
                        if (Tree.Nodes[0].Nodes[i].Text == nodeName)
                        {
                            Tree.Nodes[0].Nodes[i].Nodes.Add(node);
                            break;
                        }
                    }

                    pastUnits.Add(nodeName);
                }
                else
                {
                    for (int i = 0; i < Tree.Nodes[0].Nodes.Count; i++)
                    {
                        if (Tree.Nodes[0].Nodes[i].Text == nodeName)
                        {
                            Tree.Nodes[0].Nodes[i].Nodes.Add(node);
                            break;
                        }
                    }
                }
            }

            reader.Close();
            connection.Close();
        }
    }
}
