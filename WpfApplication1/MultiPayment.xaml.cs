using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Logic;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MultiPayment.xaml
    /// </summary>
    public partial class MultiPayment : Window
    {
        public MultiPayment()
        {
            InitializeComponent();
            PaymentDataGrid.ItemsSource = new PaymentOrder().ViewPending().AsDataView();
           SchoolName.ItemsSource = new School().Names();

        }

        private void SchoolName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PaymentDataGrid.ItemsSource = new PaymentOrder().Viewpending((string)SchoolName.SelectedItem).AsDataView();
        }

        private void RecieveAmount_Click(object sender, RoutedEventArgs e)
        {
            if (PaymentDataGrid.SelectedItems.Count!=0)
            {
                List<PaymentOrder> paymentOrders = new List<PaymentOrder>();
                foreach (object t in PaymentDataGrid.SelectedItems)
                {
                    DataRowView row = t as DataRowView;
                    if (row != null)
                    {
                        var transactionId = (int)row[0];
                        PaymentOrder payment = new PaymentOrder { Id = transactionId };
                        paymentOrders.Add(payment);
                    }
                }
                new RecievePay(paymentOrders);
                PaymentDataGrid.ItemsSource = new PaymentOrder().ViewPending().AsDataView();
            }
            else
            {
                MessageBox.Show("Please Select at least one Transaction", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}
