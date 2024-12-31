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
using System.Windows.Shapes;
using UserManagement.UI;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace UserManagement
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {


        ListPage listp;
        UserPage userp;
        HomePage homep;
        public MainWindow1()
        //public MainWindow1(string username)
        {
            InitializeComponent();
            //this.Title = "Welcome Mr." + username;
            //HomePage homep = new HomePage();
            //mainframe.Content = homep;

            listp = new ListPage();
          //  userp = new UserPage();
            homep = new HomePage();
        }
        private void btnlstuser_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Content = listp;
        }
        private void btnuser_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Content = userp;
        }
        private void btnhome_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Content = homep;
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (mainframe.CanGoBack)
            {
                mainframe.GoBack();
            }
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (mainframe.CanGoForward)
            {
                mainframe.GoForward();
            }
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
           
              

        }

        private void btnwrite_Click(object sender, RoutedEventArgs e)
        {

           

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
