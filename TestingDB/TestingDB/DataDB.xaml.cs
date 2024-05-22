using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Dapper;

namespace TestingDB
{
    /// <summary>
    /// Логика взаимодействия для DataDB.xaml
    /// </summary>
    public partial class DataDB : Window
    {
        public class Product
        {
            public int id_Product { get; set; }
            public string Name { get; set; }
            public float Price { get; set; }
        }

        public class PaginatedData
        {
            public List<Product> Products { get; set; }
            public int TotalCount { get; set; }
        }

        private string _connectionString = "Server=DESKTOP-TMUJ2QU\\OLEGSQL2;DataBase=DapperTest;Integrated Security=SSPI;";
        public DataDB()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                //  Получение списка продуктов с помощью Dapper
                var products = connection.Query<Product>("SELECT * FROM Products").ToList();

                //  Привязка данных к DataGrid
                ProdDG.ItemsSource = new ObservableCollection<Product>(products);
            }


        }
        private PaginatedData GetPaginatedProducts(int pageNumber, int pageSize, string filter)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                //  Строка запроса с пагинацией и фильтрацией
                string sql = @"
            SELECT * FROM Products
            WHERE (@Filter IS NULL OR Name LIKE '%' + @Filter + '%')
            ORDER BY Name
            OFFSET (@PageNumber - 1) * @PageSize ROWS
            FETCH NEXT @PageSize ROWS ONLY";
                //  Параметры запроса
                var parameters = new
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    Filter = filter
                };
                //  Выполнение запроса с помощью Dapper
                var products = connection.Query<Product>(sql, parameters).ToList();
                //  Получение общего количества записей
                var totalCount = connection.QuerySingle<int>("SELECT COUNT(*) FROM Products");
                return new PaginatedData { Products = products, TotalCount = totalCount };
            }
        }
        private int _currentPage = 1;
        private const int _pageSize = 10;
        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            PaginFilter();
        }
        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                PaginFilter();
            }
        }
        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            _currentPage++;
            PaginFilter();
        }
        private void PaginFilter()
        {
            string filter = filterTextBox.Text;
            var paginatedData = GetPaginatedProducts(_currentPage, _pageSize, filter);
            ProdDG.ItemsSource = paginatedData.Products;
            pageNumberTextBlock.Text = $"Страница {_currentPage}";
            //  Кнопки пагинации
            previousPageButton.IsEnabled = _currentPage > 1;
            nextPageButton.IsEnabled = _currentPage < (paginatedData.TotalCount / _pageSize) + 1;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddData addData = new AddData();
            addData.Show();
            this.Close();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            // Получение выбранного продукта из DataGrid
            Product selectedProduct = ProdDG.SelectedItem as Product;
            if (selectedProduct != null)
            {
                // Создание окна для редактирования
                EditData editdata = new EditData(selectedProduct);
                if (editdata.ShowDialog() == true)
                {
                    // Обновление продукта в базе данных
                    using (IDbConnection db = new SqlConnection(_connectionString))
                    {
                        db.Execute("UPDATE Products SET Name = @Name, Price = @Price WHERE id_Product = @id_Product", editdata.Product);
                    }
                    // Обновление данных в DataGrid
                    LoadProducts();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для редактирования.");
            }
        }

            private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            // Получение выбранного продукта из DataGrid
            Product selectedProduct = ProdDG.SelectedItem as Product;
            if (selectedProduct != null)
            {
                // Удаление выбранного продукта из базы данных
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    db.Execute("DELETE FROM Products WHERE id_Product = @id_Product", selectedProduct);
                }
                // Обновление данных в DataGrid
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для удаления.");

            }
        }
    }
}