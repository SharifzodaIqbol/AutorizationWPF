using Microsoft.EntityFrameworkCore;
using System.Windows;


namespace ToDoApp
{
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
            // Показываем окно авторизации перед загрузкой главного окна
            var userWindow = new UserWindow(new User());
            if (userWindow.ShowDialog() != true)
            {
                // Если авторизация не удалась, закрываем приложение
                Application.Current.Shutdown();
            }

            Loaded += MainWindow_Loaded;
        }
        // при загрузке окна
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // гарантируем, что база данных создана
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Users.Load();
            // и устанавливаем данные в качестве контекста
            DataContext = db.Users.Local.ToObservableCollection();
        }

    }
}