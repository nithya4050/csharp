using System.IO;
using System.Windows;
using System.Data; 

namespace Desinging
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(pwdpassword.Password))
            {
                MessageBox.Show("Please fill valid Data");
            }
            else
            {
                string userpath = Properties.Settings.Default.Rootpath;
                string filename = userpath + "//" + txtusername.Text + "//" + txtusername.Text + ".txt";

                if (File.Exists(filename))
                {
                    string Read_data = File.ReadAllText(filename);
                    string[] User_Data = Read_data.Split('|');

                    if (User_Data.Length > 0)
                    {
                        if (User_Data[0] == txtusername.Text && User_Data[1] == pwdpassword.Password)
                        {
                          //  HomePage homepage = new HomePage(txtusername.Text);
                           // homepage.Show();
                        }
                    }

                }
            }
        }
    }
}
