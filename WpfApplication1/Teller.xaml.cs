using System.Windows;
using WpfApplication1.Logic;
using Application = System.Windows.Forms.Application;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Teller.xaml
    /// </summary>
    public partial class Teller : Window
    {
        public Teller()
        {
            InitializeComponent();
            Log.Logging(new LoginUser());
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    PaymentOrderForm pm = new PaymentOrderForm();
        //    pm.ShowDialog();

        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PaymentOrderForm pm = new PaymentOrderForm();
            pm.ShowDialog();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Log.Logout(new LoginUser());
            Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginUserName.Text = new LoginUser().Username();
        }

        private void RecievePayMent_OnClick(object sender, RoutedEventArgs e)
        {
            new RecievePayment().ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var response = MessageBox.Show("Do you really want to log out ?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

            if (response == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Log.Logout(new LoginUser());
                App.Current.Shutdown();
                Application.Restart();
            }
        }
    }
}
