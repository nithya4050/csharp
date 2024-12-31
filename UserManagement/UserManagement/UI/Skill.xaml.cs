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
    /// Interaction logic for Skill.xaml
    /// </summary>
    public partial class Skill : Page
    {
        public Skill()
        {
            InitializeComponent();
            string path = Properties.Settings.Default.Rootpath;
            string skillpath = path + "//MasterData" + "//skill.txt";
            if(File.Exists(skillpath))
            {
                string[] val = File.ReadAllLines(skillpath);
                txtskills.Text = string.Join("\r\n", val);
            }
            //else
            //{
            //    File.Create(skillpath);
            //    string[] val = File.ReadAllLines(skillpath);
            //    txtskills.Text = string.Join("\r\n", val);
            //}
           
        }

        private void btnaddskills_Click(object sender, RoutedEventArgs e)
        {


            string path = Properties.Settings.Default.Rootpath;
            string skillpath = path + "//MasterData" + "//skill.txt";
            string[] skillcontent = txtskills.Text.Split("\r\n");
            File.WriteAllLines(skillpath, skillcontent);


        }

        private void btnpreviewskills_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration("admin","ta_IN");
            registration.Show();
        }
    }
}
