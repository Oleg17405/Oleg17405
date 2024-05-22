using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Dapper;
using static TestingDB.DataDB;

namespace TestingDB
{
    /// <summary>
    /// Логика взаимодействия для RegDB.xaml
    /// </summary>
    public partial class RegDB : Window
    {
        public class User
        {
            public int id_User { get; set; }
            public string Name { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
        }
        public RegDB()
        {
            InitializeComponent();
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
            string connectionString = "Server=DESKTOP-TMUJ2QU\\OLEGSQL2;DataBase=DapperTest;Integrated Security=SSPI;";
            if (NameTxb.Text != "" & LogTxb.Text != "" & (PasTxb.Text != "" | PasPB.Password != "")) 
            {
                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        var user = new User { Name = "", Login = "", Password = "" }; ;
                        if (PasPB.Visibility == Visibility.Visible)
                        {
                            user = new User { Name = NameTxb.Text, Login = LogTxb.Text, Password = PasPB.Password };
                        }
                        else
                        {
                            user = new User { Name = NameTxb.Text, Login = LogTxb.Text, Password = PasTxb.Text };
                        }
                        string query = "INSERT INTO Users (Name, Login, Password) VALUES (@Name, @Login, @Password)";
                        connection.Execute(query, user);
                    }
                }
                catch {
                    MessageBox.Show("Введите данные");
                }
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
