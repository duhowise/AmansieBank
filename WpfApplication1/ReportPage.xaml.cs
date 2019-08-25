using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Telerik.ReportViewer.Wpf;
using WpfApplication1.Logic;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Window
    {
       public ReportPage()
        {
            InitializeComponent();
            ReportType.Items.Add("Pending Transactions");
            ReportType.Items.Add("Cleared Transactions");
           
        }


        private void ReportType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string) ReportType.SelectedItem == "Cleared Transactions")
            {
                try
                {
                    AmansieReportViewer.ReportSource = new ClearedReport();
                    AmansieReportViewer.RefreshReport();
                    AmansieReportViewer.ZoomMode = ZoomMode.PageWidth;
                    AmansieReportViewer.ViewMode = ViewMode.PrintPreview;
                }
                catch (Exception exception)
                {
                    Log.Error(exception);
                }
            }
            if ((string)ReportType.SelectedItem == "Pending Transactions")
            {
                try
                {
                    AmansieReportViewer.ReportSource = new PendingReport();
                    AmansieReportViewer.ZoomMode = ZoomMode.PageWidth;
                    AmansieReportViewer.ViewMode = ViewMode.PrintPreview;
                    AmansieReportViewer.RefreshReport();
                }
                catch (Exception exception)
                {
                    Log.Error(exception);
                }
            }
            if ((string)ReportType.SelectedItem == "Security Transactions")
            {
                try
                {
                    AmansieReportViewer.ReportSource = new SecurityReport();
                    AmansieReportViewer.ZoomMode = ZoomMode.PageWidth;
                    AmansieReportViewer.ViewMode = ViewMode.PrintPreview;
                    AmansieReportViewer.RefreshReport();
                }
                catch (Exception exception)
                {
                    Log.Error(exception);
                }
            }
        }

        private void ReportPage_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab && (Keyboard.Modifiers & (ModifierKeys.Control | ModifierKeys.Shift)) == (ModifierKeys.Control | ModifierKeys.Shift))
            {
                ReportType.Items.Add("Security Transactions");
            }
        }
    }
}
