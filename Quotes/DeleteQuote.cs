using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace Quotes
{
    public partial class DeleteQuote : Form
    {
        public int RI;//Глобальная переменная для послудющего чтения ID из таблицы
        private SQLiteConnection connection = null;//Выделение памяти для экземпляров класса, чтобы каждый раз не выделять заново.
        private SQLiteDataAdapter adapter = null;
        private DataSet dataset = null;
        private SQLiteCommand sqlitecommand = null;
        public string alldatastring = $"SELECT * FROM QuotesTable";
        public DeleteQuote()
        {
            InitializeComponent();
        }
        public void rename() // Метод для переименования названия столбцов БД
        {
            DGVDelete.Columns[1].HeaderText = "Цитата";
            DGVDelete.Columns[2].HeaderText = "Персонаж";
            DGVDelete.Columns[3].HeaderText = "Источник";

        }

        private void DeleteQuote_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["liteconnect"].ConnectionString); //строка подключения к SQlite (описана в файле App.config в 11 строке)
            connection.Open();
            adapter = new SQLiteDataAdapter(alldatastring, connection);
            dataset = new DataSet();
            adapter.Fill(dataset, "QuotesTable");
            DGVDelete.DataSource = dataset.Tables["QuotesTable"]; //Заполнение DatagridView
            rename();
        }

        private void DGVDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DeleteButton_Click(object sender, EventArgs e) //Кнопка удаления
        {
            try
            {
                object key = DGVDelete[0, RI].Value;//чтение ID из таблицы DatagridView для удаления
                string deletestring = $"DELETE FROM QuotesTable WHERE ID ={key}";//Команда удаления
                sqlitecommand = new SQLiteCommand(deletestring, connection);
                sqlitecommand.ExecuteNonQuery();
                adapter = new SQLiteDataAdapter(alldatastring, connection);
                dataset = new DataSet();
                adapter.Fill(dataset, "QuotesTable");
                DGVDelete.DataSource = dataset.Tables["QuotesTable"];//Заполнение DatagridView
                rename();
            }
            catch 
            {
            }


        }

        public void DGVCellClick(object sender, DataGridViewCellEventArgs e)
        {
            RI = e.RowIndex; //Заносим индекс строки в глобальную переменную
   
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            string deleteallstring = $"DROP TABLE QuotesTable";//строка для удаления таблицы
            sqlitecommand = new SQLiteCommand(deleteallstring,connection);
            sqlitecommand.ExecuteNonQuery();
            string addtable = "CREATE TABLE QuotesTable(ID	INTEGER NOT NULL UNIQUE,QUOTE TEXT NOT NULL,CHARACTER TEXT NOT NULL, MOVIE TEXT NOT NULL,PRIMARY KEY(ID AUTOINCREMENT))"; // строка для создания точно такой же таблицы
            sqlitecommand = new SQLiteCommand(addtable, connection);
            sqlitecommand.ExecuteNonQuery();
            adapter = new SQLiteDataAdapter(alldatastring, connection);
            dataset = new DataSet();
            adapter.Fill(dataset, "QuotesTable");
            DGVDelete.DataSource = dataset.Tables["QuotesTable"];//Заполнение DatagridView
            rename();



        }

    }
}
