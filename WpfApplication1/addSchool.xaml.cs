using System;
using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Logic;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for addSchool.xaml
    /// </summary>
    public partial class addSchool : Window
    {
        public addSchool()
        {
            InitializeComponent();
            institution.Items.Add("Secondary");
            institution.Items.Add("Tertiary");
            selectInstitution.Items.Add("Tertiary");
            selectInstitution.Items.Add("Secondary");
        }

        public int TypeId = 1;
        public int CategoryId = 1;
        private void SaveSchool_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(schoolName.Text) || string.IsNullOrEmpty(institution.SelectedItem.ToString()))
            {
                MessageBox.Show("All Feilds Are Required", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                var addschool=new School();
                addschool.SchoolName = $"{schoolName.Text.ToUpper()}";
                addschool.TypeId = TypeId;
               new Add().School(addschool);

               
            }
        }
        private void SaveInterest_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(updateInterest.Text) || string.IsNullOrEmpty(selectInstitution.SelectedItem.ToString()))
            {
                MessageBox.Show("All Feilds Are Required", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                var amount = Convert.ToDouble(updateInterest.Text);
                new Add().CategoryInterest(CategoryId,amount,updateInterest.Text);
            }
        }

        private void institution_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)institution.SelectedItem== "Tertiary")
            {
                TypeId = 2;
            }
        }

        private void selectInstitution_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)institution.SelectedItem == "Tertiary")
            {
                TypeId = 2;
            }
        }
    }
}
