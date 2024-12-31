using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Xml.Linq;
using UserManagement.UI;


namespace UserManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name;
        string gender;
        string education;
        string skills;
        string nationality;
        string state;
        string place;
        string regno;
        string dateofbirth;
        string age;
        string email;
        string phoneno;
        string address;
        string username;
        string Password;


        public MainWindow()
        {

            CultureInfo culture = new CultureInfo(Properties.Settings.Default.language);
            Thread.CurrentThread.CurrentUICulture = culture;

            InitializeComponent();


            cmblanguage.Items.Add("te-IN");
            cmblanguage.Items.Add("ta-IN");
            cmblanguage.Items.Add("te-IN");
            cmblanguage.Items.Add("mI-IN");
            cmblanguage.SelectedItem = Properties.Settings.Default.language;

            this.Title = Properties.Settings.Default.company;

        }

        private void cmblanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResourceManager rmanager = new ResourceManager("UserManagement.Properties.Resources", Assembly.GetExecutingAssembly());

            Properties.Settings.Default.language = cmblanguage.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            String lang = rmanager.GetString("languagealert");
            //MessageBoxResult result = MessageBox.Show(lang,"Jsquare", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //if(result == MessageBoxResult.Yes)
            //{
            //    Application.Current.Shutdown();
            //}

        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
                 string userpath = Properties.Settings.Default.Rootpath;
                 string filename = userpath + "//" + txtusername.Text + "//" + txtusername.Text + ".txt";
                      
                if(File.Exists(filename))
                {
                    string Read_data = File.ReadAllText(filename);
                    string[] User_Data = Read_data.Split("|");

                    name = User_Data[0];
                    gender = User_Data[1];
                    education = User_Data[2];
                    skills = User_Data[3];
                    nationality = User_Data[4];
                    state = User_Data[5];
                    place = User_Data[6];
                    regno = User_Data[7];
                    dateofbirth = User_Data[8];
                    age = User_Data[9];
                    email = User_Data[10];
                    phoneno = User_Data[11];
                    address = User_Data[12];

                    username = User_Data[13];
                    Password = User_Data[14]; ;
                    if(txtusername.Text == username && pwdpassward.Password == Password)
                    {
                        Homescreen homescreen = new Homescreen(name,gender,education,skills,nationality,state,place,regno,dateofbirth,age,email,phoneno,address,txtusername.Text,pwdpassward.Password.Trim(),cmblanguage.Items.ToString());
                        homescreen.ShowDialog();
                    }
                  
                }
                else
            {
                MessageBox.Show("Invalid Password");
            }
            
            

        }

        private void btnregistration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration(txtusername.Text,cmblanguage.Items.ToString());
            registration.ShowDialog();
        }
    }
}