using System.Data;
using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Logic;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for BillsPayable.xaml
    /// </summary>
    public partial class BillsPayable : Window
    {
        public string Schoolname = string.Empty;
        public BillsPayable()
        {
            InitializeComponent();
            selectSchool.ItemsSource = new School().Names();
            totalPOAmt.Content = $"GHC {new Total().ActualAmount()}";
            totalAmtPaid.Content = $"GHC {new Total().AmountPaid()}";
            double b=new Total().AmountPaid();
            double c = b-(new Total().TotalCommission());
            billsPayables.Content = $"GHC {c}";
            standingOrder.Content = $"GHC {new Total().TotalStandingOrder()}";
        }

        private void selectSchool_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   Heading.Content = $"TRANSACTIONS FOR {selectSchool.SelectedItem} OVER THE LAST 30 DAYS";
            Schoolname= selectSchool.SelectedItem.ToString();
            schoolName.Content = selectSchool.SelectedItem.ToString();
            var details = new Total(Schoolname);
            PayablesGrid.ItemsSource = details.ViewTransactions(selectSchool.SelectedItem.ToString()).AsDataView();
            schPORecieved.Content = $"GHC {details.Recieved()}";
            schOutstanding.Content = $"GHC {details.StandingOrder()}";
            schTotalAmtPaid.Content = $"GHC {details.TotalAmount()}";
            }
    }
}
