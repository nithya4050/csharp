using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace UserManagement.UI
{
    /// <summary>
    /// Interaction logic for State.xaml
    /// </summary>
    public partial class State : Page
    {
        string path = Properties.Settings.Default.Rootpath;

        public State()
        {
            InitializeComponent();
            addstate();
        }

        private void btnaddstate_Click(object sender, RoutedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;
            if (cmbcountry.SelectedItem.ToString() != null)
            {
                
                if(Directory.Exists(path + "//MasterData" + "//State"))
                {
                    string pathcountry = path + "//MasterData" + "//State" + "//" + cmbcountry.Text + ".txt";
                    //string pathcountry = Path.Join(Rootpath, "MasterData", "State", cmbcountry.SelectedItem + ".txt");

                    string[] statedata = txtstate.Text.Split("\r\n");
                    File.WriteAllLines(pathcountry, statedata);
                }
                else
                {
                    Directory.CreateDirectory(path + "//MasterData" + "//State");
                }
                
            }
            else
            {
                MessageBox.Show("please select country first");                
            }

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

        private void btnpreviewstate_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration("admin", "ta_IN");
            registration.Show();
        }

        private void cmbcountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;

            string statepath = path + "//MasterData" + "//State" + "//" + cmbcountry.SelectedItem.ToString() + ".txt";
            if (File.Exists(statepath))
            {
                string[] state = File.ReadAllLines(statepath);
                txtstate.Text = string.Join("\r\n", state);
            }
        }
    }
}
