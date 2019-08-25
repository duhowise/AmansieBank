using System.Windows;
using WpfApplication1.Logic;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("All Details Are Required", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                Password.Password = "";
                userName.Text = "";
                userName.Focus();
            }
            else
            {
               var crypt= Verify.Encrypt(Password.Password);
                var valid = LoginUser.Valid(userName.Text.Trim(),crypt);
                if (valid == false)
                {
                    MessageBox.Show("Please check username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    Password.Password = "";
                    userName.Text = "";
                    userName.Focus();
                }
                else
                {
                    var id = new LoginUser().Role();
                    if (id == 1)
                    {
                        Hide();
                        new Teller().Show();
                    }
                    else if (id == 2)
                    {
                        Hide();
                        new Officer().Show();
                    }
                }

            }
        }
 
    }
}
