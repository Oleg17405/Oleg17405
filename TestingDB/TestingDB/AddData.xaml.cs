using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static TestingDB.DataDB;
using Dapper;


namespace TestingDB
{
    /// <summary>
    /// Логика взаимодействия для AddData.xaml
    /// </summary>
    public partial class AddData : Window
    {
        private string _connectionString = "Server=DESKTOP-TMUJ2QU\\OLEGSQL2;DataBase=DapperTest;Integrated Security=SSPI;";
        public AddData()
        {
            InitializeComponent();
        }
        private void SaveProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NameTxb.Text != "" & PriceTxb.Text != "")
                {
                    // Создание нового объекта Product
                    Product newProduct = new Product
                    {
                        Name = NameTxb.Text,
                        Price = float.Parse(PriceTxb.Text)
                    };
                    // Добавление нового продукта в базу данных
                    using (IDbConnection db = new SqlConnection(_connectionString))
                    {
                        db.Execute("INSERT INTO Products (Name, Price) VALUES (@Name, @Price)", newProduct);
                    }
                    DataDB dataDB = new DataDB();
                    dataDB.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите данные!");
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных!");
            }
        }

    }
}
