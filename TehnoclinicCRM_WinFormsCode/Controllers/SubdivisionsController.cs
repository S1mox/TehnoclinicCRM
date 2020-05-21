using System.Data;
using System.Data.OleDb;

namespace TehnoclinicCRM_WinFormsCode.Controllers
{
    class SubdivisionsController
    {
        OleDbConnection connection = new OleDbConnection(ConstStrings.ConnectionString);        // Объект для подключения к БД
        OleDbCommand command = new OleDbCommand();  // Объект для управления запросами SQL
        OleDbDataAdapter adapter = new OleDbDataAdapter();  // Работа с таблицей БД

        public DataTable table = new DataTable();  // Буффер таблицы

        public DataTable UpdateTable()
        {
            connection.Open();

            adapter = new OleDbDataAdapter("SELECT * FROM Подразделения", connection);

            table.Clear();
            adapter.Fill(table);

            connection.Close();

            return table;
        }
    }
}
