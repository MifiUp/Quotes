using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;

namespace Quotes
{
    public partial class AddQuote : Form
    {
        private SQLiteConnection connection = null;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["liteconnect"].ConnectionString);//строка подключения к SQlite (описана в файле App.config в 11 строке)
            connection.Open();
        }
        public int Add(string quote, string character,string movie) //метод для добавления записи
        {
            if (quote != "" && character != "" && movie != "") //Проверка, чтобы случайно не занести пустые значения
            {
                string insertstring = $"INSERT INTO QuotesTable (QUOTE, CHARACTER, MOVIE) VALUES ('{quote}','{character}','{movie}')"; // строка вставки в таблицу
                SQLiteCommand insertcommand = new SQLiteCommand(insertstring, connection);
                int number = insertcommand.ExecuteNonQuery();
                return number;// при успешном добавлении вернет 1
            }
            else
            {
                return 0;//иначе 0
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["liteconnect"].ConnectionString);
            connection.Open();
            using (connection)
            {
               int count = Add(QuoteTextBox.Text, CharacterTextBox.Text, MovieTextBox.Text); // передача значений текстбоксов в метод для добавления записи в БД
                QuoteTextBox.Clear();//Очистка текстбоксов
                CharacterTextBox.Clear();
                MovieTextBox.Clear();
                MessageBox.Show("Добавлено цитат: " + count); //вывод успешного(1) или неуспешного(0) завершения задачи
            }

        }
    }
}
