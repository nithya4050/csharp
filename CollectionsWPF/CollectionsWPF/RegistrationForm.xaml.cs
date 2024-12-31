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
using System.Windows.Shapes;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        string Rootpath;
        public RegistrationForm()
        {
            InitializeComponent();



            Rootpath = System.Environment.SpecialFolder.CommonApplicationData.ToString();
            Rootpath = Rootpath + "//JSDesinging";
            // Rootpath = Path.Join(Rootpath, "JSUserManagement");
            if (!Directory.Exists(Rootpath))
            {
                Directory.CreateDirectory(Rootpath);
            }


            // i saved rootpath

            CollectionsWPF.Properties.Settings.Default.Rootpath = Rootpath;
            CollectionsWPF.Properties.Settings.Default.Save();
        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtusername.Text) || String.IsNullOrEmpty(txtpassword.Text) || String.IsNullOrEmpty(txtdateofbirth.Text) || String.IsNullOrEmpty(txtage.Text) || String.IsNullOrEmpty(txtemailid.Text) || String.IsNullOrEmpty(txtphoneno.Text))
            {
                MessageBox.Show("Please fill all data");
            }
            else
            {
                string userpath = Properties.Settings.Default.Rootpath + "/" + txtusername.Text;
                if (!Directory.Exists(userpath))
                {
                    Directory.CreateDirectory(userpath);
                    string filename = userpath + "//" + txtusername.Text + ".txt";
                    string content = $"{txtusername.Text}|{txtpassword.Text}|{txtdateofbirth.Text}|{txtage.Text}|{txtphoneno.Text}|{txtemailid.Text}";
                    File.WriteAllText(filename, content);

                    //Password file save 

                    string filepwd = userpath + "//Password.txt";
                    string Pwd_content = $"{txtusername.Text}|{txtpassword.Text}";
                    File.WriteAllText(filepwd, Pwd_content);


                    MessageBox.Show("Details Save Successfully");
                }
            }
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            Login loginpage = new Login();
            loginpage.ShowDialog();
            this.Close();
        }
    }
}
