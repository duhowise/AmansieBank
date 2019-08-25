using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using WpfApplication1.Logic;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using MessageBox = System.Windows.MessageBox;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for PaymentOrderForm.xaml
    /// </summary>
    public partial class PaymentOrderForm : Window
    {
        public School paytoschoolchool;
        public PaymentOrderForm()
        {
            InitializeComponent();
            school.ItemsSource = new School().Names();
            PendingDataGrid.ItemsSource=new PaymentOrder().ViewPending().AsDataView();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z.]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(poNumber.Text) || string.IsNullOrEmpty(beneficiary.Text) || string.IsNullOrEmpty(payee.Text) || string.IsNullOrEmpty(phone.Text) || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(interest.Text)||string.IsNullOrEmpty(school.SelectedItem.ToString()))
            {
                MessageBox.Show("All Feild Are Required", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                PaymentOrder payment = new PaymentOrder(poNumber.Text, beneficiary.Text, payee.Text, phone.Text,
                   Convert.ToDouble(amount.Text), Convert.ToDouble(interest.Text), paytoschoolchool.Id, LoginUser.UserId, null);
                payment.Save(payment);
                PendingDataGrid.ItemsSource = new PaymentOrder().ViewPending().AsDataView();
            }

        }

        private void amount_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //if (!IsaDigit((Keys)e.Key))
            //{
            //    MessageBox.Show("Only Numeric Input Allowed", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
               
            //}
        }

      

        private void beneficiary_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //if (IsaDigit((Keys)e.Key))
            //{
            //MessageBox.Show("Please Donot Enter Numbers", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            //   }
        }

        private void school_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            paytoschoolchool = new School(school.SelectedItem.ToString());
            interest.Text = paytoschoolchool.Amount().ToString();
        }

        private void Phone_OnKeyUp(object sender, KeyEventArgs e)
        {
    //        string disallowed = @"!@#$%^&*()_+-=QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
    //if (disallowed.Any() == phone.Text.Any())
    //        {
    //        MessageBox.Show("Please Enter Numbers", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
    //            phone.Text = "";
    //        }
        }

        private void Payee_OnKeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Amount_OnKeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
