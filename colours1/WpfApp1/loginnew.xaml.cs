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
    /// Interaction logic for loginnew.xaml
    /// </summary>
    public partial class loginnew : Window
    {
        public loginnew()
        {
            InitializeComponent();
        }
        int count = 0;
        string username = "Admin";
        string password = "Welcome";

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
                    if (count ==1)
                    {
                        MessageBox.Show("Invalid Username and password");
                    }
                    else if(count == 2)
                    {
                        MessageBox.Show("" +
                            "Alert! one time remain system will lock");
                    }
                    else if (count == 3)
                    {
                        MessageBox.Show("Your system lock");
                        btnlogin.IsEnabled = false;
                        txtusername.IsReadOnly = true;
                        pwdpassward.IsEnabled = false;
                    }
                   
                    errpwd.Content = "";
                    errusername.Content = "";
                    count++;
                }
            }
        }

       

        private void btnspecialrequest_Click(object sender, RoutedEventArgs e)
        {
            btnlogin.IsEnabled = true;
            txtusername.IsReadOnly = false;
            pwdpassward.IsEnabled = true;
        }
    }
}
