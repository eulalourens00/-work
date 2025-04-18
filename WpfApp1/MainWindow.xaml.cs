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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ILoginButton
    {
        public MainWindow()
        {
            InitializeComponent();

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
            MessageBox.Show($"Email: {email}\nPassword: {password}");
        }

        public void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            EmailTextBox.Text = string.Empty;
            PasswordTextBox.Clear();
        }
    }
}