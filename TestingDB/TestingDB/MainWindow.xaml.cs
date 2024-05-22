using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dapper;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace TestingDB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server=DESKTOP-TMUJ2QU\\OLEGSQL2;DataBase=DapperTest;Integrated Security=SSPI;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string password;
                string login = LogTxb.Text;
                if (PasTxb.Visibility == Visibility.Visible)
                {
                    password = PasTxb.Text;
                }
                else
                {
                    password = PasPB.Password;
                }
                string query = "SELECT * FROM Users WHERE Login = @login AND Password = @password";
                var result = connection.QueryFirstOrDefault(query, new { Login = login, Password = password });

                if (result != null)
                {
                    DataDB dataDB = new DataDB();
                    dataDB.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
            }
        }

        private void ChekPas_Checked(object sender, RoutedEventArgs e)
        {
            PasTxb.Visibility = Visibility.Collapsed;
            PasPB.Password = PasTxb.Text;
            PasPB.Visibility = Visibility.Visible;
        }

        private void ChekPas_Unchecked(object sender, RoutedEventArgs e)
        {
            PasPB.Visibility = Visibility.Collapsed;
            PasTxb.Text = PasPB.Password;
            PasTxb.Visibility = Visibility.Visible;
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            RegDB regDB = new RegDB();
            regDB.Show();
            this.Close();
        }
    }
}
