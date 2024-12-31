using System;
using System.Collections.Generic;
using System.Configuration;
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
using CollectionsWPF.UI;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        string home_password = "";
        string home_dateofbirth = "";
        string home_age = "";
        string home_phoneno = "";
        string home_email = "";

        public HomePage(string username, string password, string dateofbirth, string age, string phonenumber, string emailid)
        {
            InitializeComponent();

            txtusername.Text = username;
            home_password = password;
            home_dateofbirth = dateofbirth;
            home_age = age;
            home_phoneno = phonenumber;
            home_email = emailid;
        }

        private void btnhome_Click(object sender, RoutedEventArgs e)
        {
            Homepagenew home = new Homepagenew(txtusername.Text);
            mainframe.Content = home;

        }

        private void btnuser_Click(object sender, RoutedEventArgs e)
        {
            UserPage userpage = new UserPage(txtusername.Text, home_password, home_dateofbirth, home_age, home_phoneno, home_email);
            mainframe.Content = userpage;

        }

        private void btnlocation_Click(object sender, RoutedEventArgs e)
        {
            Location location = new Location(txtusername.Text);
            mainframe.Content = location;
        }

        private void btnsettings_Click(object sender, RoutedEventArgs e)
        {
            settingspage setting = new settingspage(txtusername.Text);
            mainframe.Content = setting;
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
