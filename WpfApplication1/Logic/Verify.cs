using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace WpfApplication1.Logic
{
    public static  class Verify
    {
        private static void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private static void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public static string Encrypt(string password)
        {
            using (MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8=new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);
                }
        }
    }
}