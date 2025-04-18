using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.view;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ILoginButton
    {
        private View _userViewModel;

        public MainWindow()
        {
            InitializeComponent();
            _userViewModel = new View();
            DataContext = _userViewModel;
        }

        public void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,32}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email.");
                return;
            }

            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Invalid password.");
                return;
            }

            _userViewModel.AddUser(new User(email, password));
            MessageBox.Show($"User added. Total users: {_userViewModel.Users.Count}");
        }

        public void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            EmailTextBox.Text = string.Empty;
            PasswordTextBox.Clear();
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}