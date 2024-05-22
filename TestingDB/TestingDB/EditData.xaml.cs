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
using System.Windows.Shapes;
using static TestingDB.DataDB;

namespace TestingDB
{
    /// <summary>
    /// Логика взаимодействия для EditData.xaml
    /// </summary>
    public partial class EditData : Window
    {
        public Product Product { get; set; }
        public EditData(Product product)
        {
            InitializeComponent();
            Product = product;
            NameTxb.Text = product.Name;
            PriceTxb.Text = product.Price.ToString();

        }
        private void SaveProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               //Изменение данных
                if (NameTxb.Text != "" & PriceTxb.Text != "")
                {
                    Product.Name = NameTxb.Text;
                    Product.Price = float.Parse(PriceTxb.Text);
                    DialogResult = true;
                    DataDB dataDB = new DataDB();
                    
                }
                else
                {
                    MessageBox.Show("Введите данные");
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных!");
            }
        }

    }
}
