using System.Configuration;
using System.Data;
using System.Windows;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Создаем и показываем окно авторизации
            var userWindow = new UserWindow(new User());
            if (userWindow.ShowDialog() == true)
            {
                // Если авторизация успешна, показываем главное окно
                var mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                // Если авторизация не удалась, закрываем приложение
                Shutdown();
            }
        }
    }

}

