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

namespace colours1
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Email : Window
    {
        public Email()
        {
            InitializeComponent();
                        

            cmbcountry.Items.Add("India");
            cmbcountry.Items.Add("Malaysia");
            cmbcountry.Items.Add("USA");
            cmbcountry.Items.Add("UK");
            cmbcountry.Items.Add("German");
            cmbcountry.SelectedIndex = 2;

            //string[] skills = { "C", "C#", "SQL", "JAVA" };
            //lstskillnew.ItemsSource = skills;
        }

        private void btnsend_Click(object sender, RoutedEventArgs e)
        {
            string[] email = txtEmail.Text.Split(';');
            for(int i=0; i<email.Length; i++)
            {
                MessageBox.Show(email[i]);
            }
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            string[] product = txtproduct.Text.Split('\n');
            for (int i = 0; i < product.Length; i++)
            {
                string[] pname = product[i].Split('-');
                StringBuilder str = new StringBuilder();
                str.Append("Product Name: ");
                str.Append(pname[0]);
                str.Append('\n');
                str.Append("No of Quantity: ");
                str.Append(pname[1]);
                MessageBox.Show(str.ToString());
            }
        }

        private void btnaddnew_Click(object sender, RoutedEventArgs e)
        {
            lstskillnew.Items.Add("C");
            lstskillnew.Items.Add("C#");
            lstskillnew.Items.Add("SQL");
            lstskillnew.Items.Add("JAVA");
            lstskillnew.Items.Add("Dart");
        }

        private void btnaddnew1_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Add(txtcountryname.Text);

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Insert(Convert.ToInt32(txtposition.Text), txtcountryname.Text); ;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Remove(txtcountryname.Text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Clear();
        }

        private void btnPostionremove_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.RemoveAt(Convert.ToInt32(txtposition.Text));

        }
    }
}
