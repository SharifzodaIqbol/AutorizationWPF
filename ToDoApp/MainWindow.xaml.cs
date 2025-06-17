using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Input;


namespace ToDoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Переход к регистрации");
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вход в приложений");
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}