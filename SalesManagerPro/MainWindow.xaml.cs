using System.Windows;

namespace SalesManagerPro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Проста перевірка: логін admin, пароль 1234
            if (txtUser.Text == "admin" && txtPass.Password == "1234")
            {
                MessageBox.Show("Вхід успішний!", "Вітаємо");
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль!", "Помилка");
                txtPass.Clear();
            }
        }
    }
}
