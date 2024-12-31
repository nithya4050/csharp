using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desinging
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
       
        public UserPage(string username, string password, string dateofbirth, string age, string phonenumber, string emailid)
        {
            InitializeComponent();

            txtusernamedetails.Text = username;
            txtpassword.Text = password;
            txtdateofbirth.Text = dateofbirth;
            txtage.Text = age;
            txtphoneno.Text = phonenumber;
            txtemailid.Text = emailid;
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();

        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtusernamedetails.Text) || String.IsNullOrEmpty(txtpassword.Text) || String.IsNullOrEmpty(txtdateofbirth.Text) || String.IsNullOrEmpty(txtage.Text) || String.IsNullOrEmpty(txtemailid.Text) || String.IsNullOrEmpty(txtphoneno.Text))
            {
                MessageBox.Show("Please fill all data");
            }
            else
            {
                string userpath = Properties.Settings.Default.Rootpath + "/" + txtusernamedetails.Text;
                if (Directory.Exists(userpath))
                {
                    //Directory.CreateDirectory(userpath);
                    string filename = userpath + "//" + txtusernamedetails.Text + ".txt";
                    string content = $"{txtusernamedetails.Text}|{txtpassword.Text}|{txtdateofbirth.Text}|{txtage.Text}|{txtphoneno.Text}|{txtemailid.Text}";
                    File.WriteAllText(filename, content);
                    MessageBox.Show("Details Update Successfully");

                    //Password file save 

                    string filepwd = userpath + "//Password.txt";
                    string Pwd_content = $"{txtusernamedetails.Text}|{txtpassword.Text}";
                    File.WriteAllText(filepwd, Pwd_content);


                }
            }
        }
    }
}
