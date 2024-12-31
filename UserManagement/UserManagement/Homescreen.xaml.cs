using System;
using System.Collections;
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
using System.Windows.Shapes;
using UserManagement.UI;
using System.IO;
using System.Data;
using System.Runtime;
using System.Reflection;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Security.Policy;
using System.Windows.Markup;



namespace UserManagement
{
    /// <summary>
    /// Interaction logic for Homescreen.xaml
    /// </summary>

    



    public partial class Homescreen : Window
    {
        ListPage listpage;
        UserPage userpage;
        HomePage homepage;


        string cons_username = "";
        string cons_password = "";
        string Cons_language = "";
        string Cons_name = "";
        string Cons_gender;
        string Cons_education;
        string Cons_skills;
        string Cons_nationality;
        string Cons_state;
        string Cons_place;
        string Cons_regno;
        string Cons_dateofbirth;
        string Cons_age;
        string Cons_email;
        string Cons_phoneno;
        string Cons_address;
        string Cons_username;
        string Cons_password;

        //public Homescreen()



        public Homescreen(string name, string gender, string education, string skills, string nationality, string state, string place, string regno, string dateofbirth, string age, string email, string phoneno, string address, string username,string password,string language)
        {
            InitializeComponent();
            //this.Title = "Welcome Mr" + username;
            //HomePage homepage = new HomePage();
            //mainframe.Content = homepage;

            listpage = new ListPage();
            userpage = new UserPage(name,gender,education,skills,nationality,state,place,regno,dateofbirth,age,email,phoneno,address,cons_username,cons_password,Cons_language);


            Cons_language = language;
            cons_username = username;
            cons_password = password;
            Cons_language = language;
            Cons_name = name;
            Cons_gender = gender;
            Cons_education = education;
            Cons_skills = skills;
            Cons_nationality = nationality;
            Cons_phoneno = phoneno;
            Cons_address = address;
            Cons_place = place;
            Cons_regno = regno;
            Cons_dateofbirth = dateofbirth;
            Cons_age = age;
            Cons_email = email;
            Cons_state = state;

            mainframe.Content = homepage;
           
        }

        private void MasterPage_Click(object sender, RoutedEventArgs e)
        {
            MenuItem val = (MenuItem)sender;
            string menu = val.Header.ToString();
            if (menu == "Skill")
            {
                mainframe.Content = new Skill();
            }
            else if(menu == "Country")
            {
                mainframe.Content = new Country();
            }
            else if (menu == "State")
            {
                mainframe.Content = new State();
            }
            else if (menu == "City")
            {
                mainframe.Content = new City();
            }

        }


    
        private void home_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Content = homepage;
        }

        private void list_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Content = listpage;
        }

        private void user_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Content = new UserPage(Cons_name,Cons_gender,Cons_education,Cons_skills,Cons_nationality,Cons_state,Cons_place,Cons_regno,Cons_dateofbirth,Cons_age,Cons_email,Cons_phoneno,Cons_address,Cons_username,cons_password,Cons_language);

        }

        private void user_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
