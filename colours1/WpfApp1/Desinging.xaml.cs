using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace colours1
{
    /// <summary>
    /// Interaction logic for Desinging.xaml
    /// </summary>
    public partial class Desinging : Window
    {
        string username = "Admin";
        string password = "Welcome";
        public Desinging()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) == true || string.IsNullOrWhiteSpace(pwdpassward.Password) == true)
            {
                if (string.IsNullOrWhiteSpace(txtusername.Text) == true && string.IsNullOrWhiteSpace(pwdpassward.Password) == true)
                {
                    errusername.Content = "Please enter username";
                    errpwd.Content = "Please enter password";
                }
                else if (string.IsNullOrWhiteSpace(txtusername.Text) == true)
                {
                    errusername.Content = "Please enter username";
                    errpwd.Content = "";

                }
                else
                {
                    errpwd.Content = "Please enter password";
                    errusername.Content = "";

                }
            }

            if (txtusername.Text != "" || pwdpassward.Password != "")
            {
                if (username == txtusername.Text && password == pwdpassward.Password)
                {
                    MessageBox.Show("Valid Username");
                    errpwd.Content = "";
                    errusername.Content = "";
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                    errpwd.Content = "";
                    errusername.Content = "";
                }
            }
        }


        private void btnregistration_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
