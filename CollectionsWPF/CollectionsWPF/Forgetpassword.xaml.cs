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
using System.IO;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for Forgetpassword.xaml
    /// </summary>
    public partial class Forgetpassword : Window
    {

        string Path;
        public Forgetpassword(string username)
        {
            InitializeComponent();
            txtusername.Text = username;

        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Path = Properties.Settings.Default.Rootpath + "//" + txtusername.Text + "//" + txtusername.Text + ".txt";
            if (File.Exists(Path))
            {
                string getdata = File.ReadAllText(Path);
                string[] data = getdata.Split('|');
                if (data[0] == txtusername.Text)
                {
                    string pwd_path = Properties.Settings.Default.Rootpath + "//" + txtusername.Text + "//" + "Password.txt";
                    string content = $"{txtusername.Text}|{pwdpassword.Password}";
                    File.WriteAllText(pwd_path, content);
                    MessageBox.Show("Details Update Successfully");
                }
            }
            else
            {
                MessageBox.Show("Username is wrong");
            }
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
