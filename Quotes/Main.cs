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
   
    public partial class QuotesBook : Form
    {
        private SQLiteConnection connection = null;
        private SQLiteDataAdapter adapter = null;
        private DataSet dataset = null;
        public QuotesBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["liteconnect"].ConnectionString);//строка подключения к SQlite (описана в файле App.config в 11 строке)
            connection.Open();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e) //Кнопка для открытия формы добавления цитаты
        {
            AddQuote newForm = new AddQuote();
            newForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetQuoteButton_Click(object sender, EventArgs e) //Кнопка для получения цитаты
        {
            try
            {

                string randomquotestring = $"SELECT * FROM QuotesTable ORDER BY RANDOM() LIMIT 1"; // Получение случайной строки из БД
                adapter = new SQLiteDataAdapter(randomquotestring, connection);
                dataset = new DataSet();
                adapter.Fill(dataset, "QuotesTable");
                DGVQuotes.DataSource = dataset.Tables["QuotesTable"]; // Заполнение невидимой,для пользователя, таблицы DatagridView
                QuoteLabel.Text = DGVQuotes.Rows[0].Cells[1].Value.ToString();//Чтение столбца с цитатами в невидимый label
                CharacterLabel.Text = DGVQuotes.Rows[0].Cells[2].Value.ToString();//Чтение столбца с персонажем в невидимый label
                SourceLabel.Text = DGVQuotes.Rows[0].Cells[3].Value.ToString();//Чтение столбца с источником цитаты в невидимый label
                QuoteLabel.Visible = true; //Делаем label видимым
                CharacterLabel.Visible = true;
                SourceLabel.Visible = true;
            }
            catch
            {

            }
            

        }

        private void DeleteQuoteButton_Click(object sender, EventArgs e) //Кнопка для открытия формы удаления
        {
            DeleteQuote newForm1 = new DeleteQuote();
            newForm1.Show();
        }
    }
}
