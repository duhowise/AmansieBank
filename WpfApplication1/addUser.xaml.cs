using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApplication1.Logic;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for addUser.xaml
    /// </summary>
    public partial class addUser : Window
    {
        public int TypeId = 1;
      
        public addUser()
        {
            InitializeComponent();
            userType.Items.Add("Administrator");
            userType.Items.Add("Teller");
           
           // selectUser.ItemsSource = User.Names();


        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (selectUser.Items.Count!=0)
            {
                MessageBox.Show(@"There are still user(s) without Credentials");
                e.Cancel = true;
            }
        }

        //private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        //{
        //    Regex regex = new Regex("[^0-9.]+");
        //    e.Handled = regex.IsMatch(e.Text);
        //}
        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text)||string.IsNullOrEmpty(userType.SelectedItem.ToString()))
            {
                MessageBox.Show("All Feild Are Required", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                string name = $"{firstName.Text.TrimEnd()} {lastName.Text.TrimEnd()}";
                User addUser = new User {Name =name,Type = TypeId};
                addUser.Save(addUser);
                Log.UserAdded(new LoginUser(),name,userType.SelectedItem.ToString());
                selectUser.Items.Add(name);

            }
        }

        private void AddCredential_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(password.Password) || string.IsNullOrEmpty(selectUser.SelectedItem.ToString())||string.IsNullOrEmpty(password.Password))
            {
                MessageBox.Show("All Feild Are Required", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                User getUser=new User(selectUser.SelectedItem.ToString());
                var getId=getUser.FindId(getUser);
                var crypt = Verify.Encrypt(password.Password);
                var addUser=new User(getId,userName.Text,crypt);
                addUser.CreateLogin(addUser);
                userName.Text = "";
                password.Password = "";
                userType.Text = "";
                selectUser.Items.Remove(selectUser.SelectedItem);

            }
        }

        private void userType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)userType.SelectedItem== "Administrator")
            {
                TypeId = 2;
            }
        }
    }
}
