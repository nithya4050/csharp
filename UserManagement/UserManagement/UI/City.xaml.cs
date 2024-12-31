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

namespace UserManagement.UI
{
    /// <summary>
    /// Interaction logic for City.xaml
    /// </summary>
    public partial class City : Page
    {
        string path = Properties.Settings.Default.Rootpath;
        public City()
        {
            InitializeComponent();
            addstate();

        }

        private void cmbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;

            string citypath = path + "//MasterData" + "//City" + "//" + cmbState.SelectedItem.ToString() + ".txt";
            if (File.Exists(citypath))
            {
                string[] city = File.ReadAllLines(citypath);
                txtCity.Text = string.Join("\r\n", city);
                
            }
        }

        private void btnpreviewstate_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration("admin", "ta_IN");
            registration.Show();
        }


        public void addstate()
        {
            path = Properties.Settings.Default.Rootpath;
            string countrypath = path + "//MasterData" + "//country.txt";
            if (File.Exists(countrypath))
            {
                string[] val = File.ReadAllLines(countrypath);
                cmbcountry.ItemsSource = val;

            }
        }

        private void btnaddstate_Click(object sender, RoutedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;
            if (cmbState.SelectedItem.ToString() != null)
            {
                if (Directory.Exists(path + "//MasterData" + "//City"))
                {
                    string pathcity = path + "//MasterData" + "//City" + "//" + cmbState.SelectedItem + ".txt";
                    //string pathcountry = Path.Join(Rootpath, "MasterData", "State", cmbcountry.SelectedItem + ".txt");
                    
                    string[] statedata = txtCity.Text.Split("\r\n");
                    File.WriteAllLines(pathcity, statedata);
                }
                else
                {
                    Directory.CreateDirectory(path + "//MasterData" + "//City");
                }

            }
            else
            {
                MessageBox.Show("please select state first");
            }
        }

        private void cmbcountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;
            string statepath = path + "//MasterData" + "//State" + "//" + cmbcountry.SelectedItem.ToString() + ".txt";
            if (File.Exists(statepath))
            {
                string[] state = File.ReadAllLines(statepath);
                cmbState.ItemsSource = state;
                                
            }
        }

        
    }
}
