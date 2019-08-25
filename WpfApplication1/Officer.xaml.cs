using System.Windows;
using WpfApplication1.Logic;
using Application = System.Windows.Forms.Application;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Officer.xaml
    /// </summary>
    public partial class Officer : Window
    {
        public Officer()
        {
            InitializeComponent();
            LoginUserName.Text = new LoginUser().Username();
            Log.Logging(new LoginUser());
            //summaryChart.ItemsSource=new PaymentOrder().ViewPending().AsDataView();
           
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Log.Logout(new LoginUser());
            Close();
        }

        private void RecievePay_Click(object sender, RoutedEventArgs e)
        {
            new RecievePayment().ShowDialog();
        }

        private void AddInstitution_Click(object sender, RoutedEventArgs e)
        {
            new addSchool().ShowDialog();
        }

        private void AddNewUser_Click(object sender, RoutedEventArgs e)
        {
            new addUser().ShowDialog();
        }

        private void Payables_OnClick(object sender, RoutedEventArgs e)
        {
            new BillsPayable().ShowDialog();
        }

        private void Reports_OnClick(object sender, RoutedEventArgs e)
        {
            //new ReportForm().ShowDialog();
            new ReportPage().ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var response = MessageBox.Show("Do you really want to log out?", "Logout",MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

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
