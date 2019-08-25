using System.Data;
using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Logic;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for RecievePayment.xaml
    /// </summary>
    public partial class RecievePayment : Window
    {
        public RecievePayment()
        {
            InitializeComponent();
            PaymentDataGrid.ItemsSource = new PaymentOrder().ViewPending().AsDataView();
        }

        private void RecieveAmount_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = PaymentDataGrid.SelectedItem as DataRowView;
            if (dataRow != null)
            {
                var transactionId = (int)dataRow.Row[0];
                PaymentOrder payment = new PaymentOrder { Id = transactionId };
                new RecievePay(payment);
                PaymentDataGrid.ItemsSource = new PaymentOrder().ViewPending().AsDataView();
            }
            else
            {
                MessageBox.Show("Please Select a Transaction", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void Searchbox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var data=new PaymentOrder().ViewPending(Searchbox.Text);
            PaymentDataGrid.ItemsSource = data.AsDataView();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new MultiPayment().ShowDialog();
        }
    }

    }
