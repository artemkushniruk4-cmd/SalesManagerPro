using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace SalesManagerPro
{
    public partial class MainWindow : Window
    {
        // Твій рядок підключення до бази
        private string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SalesDB;Integrated Security=True";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // Запит до твоєї таблиці Clients
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clients", conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Відправляємо дані в таблицю на екрані
                    MyGrid.ItemsSource = table.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
