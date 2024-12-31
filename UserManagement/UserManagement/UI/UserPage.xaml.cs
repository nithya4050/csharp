using System.Windows.Controls;
using System.IO;

namespace UserManagement.UI
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        string cons_username = "";
        string Cons_password = "";
        public UserPage(string name, string gender, string education, string skills, string nationality, string state, string place, string regno, string dateofbirth, string age, string email, string phoneno, string address, string username, string password, string language)
        {
            InitializeComponent();
            cons_username = username;
            Cons_password = password;
            User_Data();
            txtname.Text = name;
            txtgender.Text = gender;
            txtdob.Text = dateofbirth;
            txtskills.Text = skills;
            txtregno.Text = regno;
            txtstate.Text = state;
            txtage.Text = age;
            txtcountry.Text = nationality;
            txteducation.Text = education;
            txtemail.Text = email;
            txtplace.Text = place;
            txtphoneno.Text = phoneno;
            txtAddress.Text = address;

        }
        public void User_Data()
        {
            string userpath = Properties.Settings.Default.Rootpath;
            string filename = userpath + "//" + cons_username + "//" + cons_username + ".txt";
            string Rootpath = Properties.Settings.Default.Rootpath;
            // string path1 = Path.Join(Rootpath, cons_username, cons_username + ".txt");
        }
    }
}
