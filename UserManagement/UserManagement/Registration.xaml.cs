using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace UserManagement
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        
        string Rootpath;
        public Registration(string username="", string language="")
        {
             CultureInfo culture = new CultureInfo(Properties.Settings.Default.language);
            Thread.CurrentThread.CurrentUICulture = culture;
            InitializeComponent();

            Rootpath = System.Environment.SpecialFolder.CommonApplicationData.ToString();
             //Rootpath = Rootpath + "//JSUserManagement";
            Rootpath = Path.Join(Rootpath, "JSUserManagement");
            if (!Directory.Exists(Rootpath))
            {
                Directory.CreateDirectory(Rootpath);
            }


            //here i saved rootpath
            UserManagement.Properties.Settings.Default.Rootpath = Rootpath;
            UserManagement.Properties.Settings.Default.Save();

            //addskills();
            //addcountry();
            skillbinding();

            countrybinding();

           


            this.Title = "Welcome Mr . " + username;
            username = Properties.Settings.Default.language;
            this.Title = Properties.Settings.Default.company;


            cmbstate.Items.Add("--Select--");
            cmbplace.Items.Add("--Select--");
        }


        public void countrybinding()
        {
            ////country Binding
            string pathcountry = Path.Join(Rootpath, "MasterData", "country.txt");
            string[] country = File.ReadAllLines(pathcountry);
            country[0] = "--Select--";

            cmbcountry.ItemsSource = country;
        }
        public void skillbinding()
        {
            ////skill Binding
            string path = Path.Join(Rootpath, "MasterData", "skill.txt");
            string[] skill = File.ReadAllLines(path);
            skill[0] = "--Select--";
            lstskills.ItemsSource = skill;
        }


        public void addskills()
        {
            string path = Properties.Settings.Default.Rootpath;
            
            string skillpath =Path.Join(path,"MasterData" ,"skill.txt");
            if (File.Exists(skillpath))
            {
                string[] val = File.ReadAllLines(skillpath);
                lstskills.ItemsSource = val;
            }
        }

        public void addcountry()
        {
            string path = Properties.Settings.Default.Rootpath;
            string countrypath = Path.Join(path, "MasterData", "country.txt");
            if (File.Exists(countrypath))
            {

                string[] val = File.ReadAllLines(countrypath);

                val[0] = "--Select--";
                cmbcountry.ItemsSource = val;
                
            }
        }


        private void cmbcountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;
            cmbstate.Items.Clear();

           // string statepath = path + "//MasterData" + "//State" + "//" + cmbcountry.SelectedItem.ToString() + ".txt";

            string statepath = Path.Join(path,"MasterData","State",cmbcountry.SelectedItem.ToString() + ".txt");


            if (File.Exists(statepath))
            {
                string[] state = File.ReadAllLines(statepath);
                state[0] = "--Select--";
                cmbstate.ItemsSource = state;
            }
        }
       

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string gender = "";
            bool val_check = true;
            string list_skills = "";

            if (txtname.Text == "")
            {
                lblnamevalidation.Content = "Name is missing";
                val_check = false;
            }

            if ((rdbmale.IsChecked == false) && (rdbfemale.IsChecked == false))
            {
                lblgendervalidation.Content = "Please select male or female";
                val_check = false;
            }

            if (txteducation.Text == "")
            {
                lblEducationvalidation.Content = "Fill the Education";
                val_check = false;
            }

            if(txtphoneno.Text == "")
            {
                lblphonenovalidation.Content = "Fill the Phoneno";
                val_check = false;
            }

            if (txtregno.Text == "")
            {

                lblregnovalidation.Content = "Reg No is missing";
                val_check = false;
            }
            if (txtAddress.Text == "")
            {
                lbladdressvalidation.Content = "Address is missing";
                val_check = false;
            }

            if (lstskills.SelectedItems.Count == 0)
            {
                lblskillsvalidation.Content = "Select your skills";
                val_check = false;
            }
            else
            {
                list_skills = lstskills.SelectedItem.ToString();
            }

            if (txtage.Text == "")
            {

                lblagevalidation.Content = "Age is missing";
                val_check = false;
            }
            if (txtdob.Text == "")
            {
                lbldobvalidation.Content = "Date of Birth is missing";
                val_check = false;
            }

            if (txtemail.Text == "")
            {

                lblemailvalidation.Content = "Give Email";
                val_check = false;
            }
            if (txtpassword.Text == "")
            {
                lblpasswordvalidation.Content = "Fill Password";
                val_check = false;
            }
            if (txtusername.Text == "")
            {
                lblusernamevalidation.Content = "username is missing";
                val_check = false;
            }
            if ((cmbcountry.SelectedIndex == 0) || (cmbcountry.SelectedItem.ToString() == "--Select--"))
            {
                lblcountryvalidation.Content = "Country is missing";
                val_check = false;
            }
            //if((cmbstate.SelectedIndex == 1) && (cmbstate.Items.Count != 1))
            //{
            //    lblstatevalidation.Content = "State is missing";
            //    val_check = false;
            //}


            //if((cmbplace.SelectedIndex == 1) && (cmbplace.Items.Count != 1))
            //{
            //    lblplacevalidation.Content = "Place is missing";
            //    val_check = false;
            //}
            
            if(cmbstate.SelectedIndex == 0)
            {
                lblstatevalidation.Content = "State is missing";
                val_check = false;

            }
            if (cmbplace.SelectedIndex == 0)
            {
                lblplacevalidation.Content = "Place is missing";
                val_check = false;

            }

            //if ((cmbstate.SelectedItem.ToString() == "") || (cmbstate.SelectedItem.ToString() == "--Select--"))
            //{
            //    lblstatevalidation.Content = "State is missing";
            //}
            //if ((cmbplace.SelectedItem.ToString() == "") || (cmbplace.SelectedItem.ToString() == "--Select--"))
            //{
            //    lblplacevalidation.Content = "Place is missing";
            //}




            if (rdbmale.IsChecked == true)
            {
                gender = rdbmale.Content.ToString();
            }


            else if (rdbfemale.IsChecked == true)
            {
                gender = rdbfemale.Content.ToString();
            }

           //if(lstskills.SelectedIndex == 0)
           // {

           // }


            if (val_check == true)
            {
                validation_Lable_Clear();
                string userpath = Properties.Settings.Default.Rootpath + "/" + txtname.Text;
                if (!Directory.Exists(userpath))
                {
                    Directory.CreateDirectory(userpath);
                    string filename = userpath + "//" + txtname.Text + ".txt";
                    string content = $"{txtname.Text}|{gender}|{txteducation.Text}|{list_skills}|{cmbcountry.SelectedItem.ToString().Trim()}|{cmbstate.SelectedItem}|{cmbplace.SelectedItem}|{txtregno.Text}|{txtdob.Text}|{txtage.Text}|{txtemail.Text}|{txtphoneno.Text}|{txtAddress.Text}|{txtusername.Text}|{txtpassword.Text}";
                    File.WriteAllText(filename, content);
                    MessageBox.Show("Details Save Successfully");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Name Already exist");
                }

            }
            //Rootpath = System.Environment.CurrentDirectory;
            //string mydoc = System.Environment.SpecialFolder.MyDocuments.ToString();
            //string myvideos = System.Environment.SpecialFolder.MyVideos.ToString();
            //string appdata = System.Environment.SpecialFolder.ApplicationData.ToString();
            //string commondata = System.Environment.SpecialFolder.CommonApplicationData.ToString();
            //string localdata = System.Environment.SpecialFolder.LocalApplicationData.ToString();

        }
        public void Clear()
        {
            txtname.Text = "";
            txteducation.Text = "";
            skillbinding();
            countrybinding();
          //  cmbstate.Items.Clear();
           // cmbplace.Items.Clear();
            cmbplace.SelectedItem = "";
            txtregno.Text = "";
            txtusername.Text = "";
            txtphoneno.Text = "";
            txtemail.Text = "";
            txtdob.Text = "";
            txtAddress.Text = "";
            txtage.Text = "";
            txtpassword.Text = "";

            //cmbstate.Items.Add("--Select--");
           // cmbplace.Items.Add("--Select--");
        }
        public void validation_Lable_Clear()
        {
            lbladdressvalidation.Content = "";
            lblagevalidation.Content = "";
            lblcountryvalidation.Content = "";
            lbldobvalidation.Content = "";

            lblEducationvalidation.Content = "";
            lblemailvalidation.Content = "";
            lblgendervalidation.Content = "";
            lblnamevalidation.Content = "";
            
            lblpasswordvalidation.Content = "";
            lblphonenovalidation.Content = "";
            lblregnovalidation.Content = "";
            lblskillsvalidation.Content = "";

            lblusernamevalidation.Content = "";
            lblplacevalidation.Content = "";
            lblstatevalidation.Content = "";





        }

        private void cmbstate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = Properties.Settings.Default.Rootpath;
            if (cmbstate.SelectedItem != null)
            {
                cmbplace.Items.Clear();
                string citypath = path + "//MasterData" + "//City" + "//" + cmbstate.SelectedItem.ToString() + ".txt";
                if (File.Exists(citypath))
                {
                    string[] city = File.ReadAllLines(citypath);
                    city[0] = "--Select--";

                    cmbplace.ItemsSource = city;
                    
                }
            }

        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
    }
}
