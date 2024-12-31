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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace UserManagement.UI
{
    /// <summary>
    /// Interaction logic for Country.xaml
    /// </summary>
    public partial class Country : Page
    {
        public Country()
        {
            InitializeComponent();
            string path = Properties.Settings.Default.Rootpath;
            string countrypath = path + "//MasterData" + "//country.txt";
            if (File.Exists(countrypath))
            {
                string[] val = File.ReadAllLines(countrypath);
                txtcountry.Text = string.Join("\r\n", val);
            }
        }

        private void btnaddcountry_Click(object sender, RoutedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;
            string countrypath = path + "//MasterData" + "//country.txt";
            string[] countrycontent = txtcountry.Text.Split("\r\n");
            File.WriteAllLines(countrypath, countrycontent);
        }

        private void btnpreviewcountry_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration("admin", "ta_IN");
            registration.Show();
        }
    }
}
