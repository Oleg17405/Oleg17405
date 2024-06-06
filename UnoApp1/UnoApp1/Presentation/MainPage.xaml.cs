namespace UnoApp1.Presentation;

using System.Data;
using Dapper;
using Microsoft.Data.Sqlite;

public sealed partial class MainPage : Page
{
    string connectionString = "Data Source=C:\\Users\\oleg\\source\\repos\\UNO\\UnoApp1\\UnoApp1\\TestUno.db;";
    public MainPage()
    {
        this.InitializeComponent();
      
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
        }
    }

    private void AddDate_Click(object sender, RoutedEventArgs e)
    {
        if (textTB.Text != "")
        {
            using (IDbConnection connection = new SqliteConnection(connectionString))
            {
                string stringText = textTB.Text;
                var customer = new UserTexts { UserText = textTB.Text };
                string insertQuery = "INSERT INTO UserTexts (UserText) VALUES (@UserText)";
                connection.Execute(insertQuery, customer);
            }
        }

    }
    public class UserTexts
    {
        public int id_Text { get; set; }
        public string UserText { get; set; }
    }
}
