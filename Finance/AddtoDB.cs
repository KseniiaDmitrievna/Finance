using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    internal class AddtoDB
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Database.mdb";
        public AddtoDB()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
        }
        //SelectDB slct = new SelectDB();

        
        private OleDbConnection dbConnection;

        public void addRecord(string username, string date, string amountMoney, string category, string comment)
        {
            string query = $"INSERT INTO [Журнал_Расходов] ([Дата_покупки], [Имя] , [Категория],  [Сумма покупки],[Комментарий])VALUES('{date}','{username}' , '{category}',  '{amountMoney}','{comment}')";
            addToDB(query);
        }
        public void addNameCategory(string name, string category)
        {
            if (name != "")
            {
                string query_1 = $"INSERT INTO [Имя_пользователя] ([Имя]) VALUES ('{name}')";
                addToDB(query_1);
            }
            if (category != "")
            {
                string query_2 = $"INSERT INTO [Категория] ([Категория]) VALUES ('{category}')";
                addToDB(query_2);
            }

        }

        public void addToDB(string query)
        {
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            }
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
            }
        }

        public DataTable dataTable(string query)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, dbConnection);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            adapter.Update(dt);
            return dt;
        }

        public DataTable fillCategory()
        {
            string query = "SELECT * FROM [Категория]";
            return dataTable(query);
        }
        public DataTable fillName()
        {
            string query = "SELECT * FROM [Имя_пользователя]";
            return dataTable(query);
        }

        public DataTable sortCategory(string category)
        {
            string query = "SELECT * FROM [Журнал_расходов] WHERE Категория = '" + category + "'  ORDER BY Дата_покупки DESC";
            return dataTable(query);
        }

        public DataTable sortName(string name)
        {
            string query = "SELECT * FROM [Журнал_расходов] WHERE Имя = '" + name + "'  ORDER BY Дата_покупки DESC";
            return dataTable(query);
        }

        public DataTable sortDate(string dateStart, string dateStop)
        {
            string query = "SELECT * FROM [Журнал_расходов] WHERE ((Дата_покупки >= #" + dateStart + "#) AND (Дата_покупки <= #" + dateStop + "#  )) ORDER BY Дата_покупки DESC";
            return dataTable(query);
        }

        public DataTable publishDate()
        {
            string query = "SELECT * FROM [Журнал_расходов] ORDER BY Дата_покупки DESC";
            return dataTable(query);
        }

        public void saveDelete(string query)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, dbConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);

            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();

            adapter.Update(ds);
            MessageBox.Show("Данные удалены!", "Внимание");
        }
    }
}
