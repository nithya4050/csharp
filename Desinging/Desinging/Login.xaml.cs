using System.IO;
using System.Windows;
using System.Data;

namespace Desinging
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {


        string[] User_pwd;
        public Login()
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

                //Check in password file:

                string pwdname = userpath + "//" + txtusername.Text + "//" + "Password.txt";
                if (File.Exists(pwdname))
                {
                    string Read_pwd = File.ReadAllText(pwdname);
                    User_pwd = Read_pwd.Split('|');
                }



                if (File.Exists(filename))
                {
                    string Read_data = File.ReadAllText(filename);
                    string[] User_Data = Read_data.Split('|');

                    if (User_Data.Length > 0)
                    {
                        if (User_Data[0] == txtusername.Text && User_pwd[1] == pwdpassword.Password)
                        {
                            HomePage homepage = new HomePage(User_Data[0], User_pwd[1], User_Data[2], User_Data[3], User_Data[4], User_Data[5]);
                            homepage.Show();
                            this.Close();
                        }
                    }

                }
            }
        }

        private void btnforgetpassword_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Give Username");
            }
            else
            {
                Forgetpassword forgetpassword = new Forgetpassword(txtusername.Text);
                forgetpassword.ShowDialog();
                this.Close();
            }
        }

        private void btnsignup_Click(object sender, RoutedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            this.Close();
        }
    }
}
