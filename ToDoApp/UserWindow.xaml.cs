using System.Windows;
namespace ToDoApp
{
    public partial class UserWindow : Window
    {
        ApplicationContext db = new ApplicationContext();
        public User User { get; private set; }
        public UserWindow(User user)
        {
            InitializeComponent();
            User = user;
            DataContext = User;
        }
        private void EnterApp(object sender, RoutedEventArgs e)
        {
            UserWindow UserWindow = new UserWindow(new User());
            if (UserWindow.ShowDialog() == true)
            {
                User User = UserWindow.User;
                db.Users.Add(User);
                db.SaveChanges();
            }
        }
    }
}
