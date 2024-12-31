using Microsoft.VisualBasic;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace colours1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string username = "Admin";
        string password = "Welcome";
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            string val = "Hi";
            val = "1";
            //int count = 10;
            //count = 1;
            //bool isstudent = false;
            //isstudent = true;
            //char firstletter = 'a';
            //firstletter = 'b';
            //firstletter = 'h';

            object atvalue = 1;
            atvalue = "cg";
            atvalue = 'h';
            atvalue = true;
            atvalue = val;
            atvalue = false;
            atvalue = "cg";

            dynamic dd = 1;
            dynamic v1= "value";
            dynamic d1 = val;
            dynamic d2 =true;




            if (string.IsNullOrWhiteSpace(txtusername.Text) == true || string.IsNullOrWhiteSpace(pwdpassward.Password) == true)
            {
                if (string.IsNullOrWhiteSpace(txtusername.Text) == true && string.IsNullOrWhiteSpace(pwdpassward.Password) == true)
                {
                    errusername.Content = "Please enter username";
                    errpwd.Content = "Please enter password";
                }
                else if (string.IsNullOrWhiteSpace(txtusername.Text)== true)
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

            
            //if (username == txtusername.Text.ToString())
            //{
            //    if (password == pwdpassward.ToString())
            //    {
            //        MessageBox.Show("valid Username");
            //    }
            //}
        

        private void btnregistration_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
