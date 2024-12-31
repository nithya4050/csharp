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
    /// Interaction logic for listbox.xaml
    /// </summary>
    public partial class listbox : Window
    {
        public listbox()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            if (txtname.Text != "")
            {
                lblnameandindex.Content = "";
                comboname.Items.Add(txtname.Text);
                txtname.Text = null;
            }
            else
            {
                lblnameandindex.Content = "Fill name";
            }
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            if (txtpositionno.Text != "")
            {
                comboname.Items.Insert(Convert.ToInt16(txtpositionno.Text), txtname.Text);
                txtpositionno.Text = null;
                txtname.Text = null;
            }
            else
            {
                lblnameandindex.Content = "Fill Index";
            }
        }

        private void btnbind_Click(object sender, RoutedEventArgs e)
        {
            string[] skills = txtskills.Text.Split('\r');
            for(int i=0; i<skills.Length; i++)
            {
                comboskills.Items.Add(skills[i]);
            }
            //comboskills.ItemsSource = skills;
            txtskills.Text = null;
        }

       
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            comboskills.Items.Clear();
            txtskills.Text = null;
        }

      

        private void btnremove_Click(object sender, RoutedEventArgs e)
        {
            if (txtremoveskills.Text == "" && txtremoveindex.Text == "")
            {
                lblremove.Content = "Fill Remove skill";
            }
            else if(txtremoveskills.Text != "")
            {
                comboskills.Items.Remove(txtremoveskills.Text);
                lblremove.Content = null;
                txtremoveskills.Text = null;

            }
            else if (txtremoveindex.Text != "")
            {
                comboskills.Items.RemoveAt(Convert.ToInt16(txtremoveindex.Text));
                lblremove.Content = null;
                txtremoveindex.Text = null;
            }


        }
    }
}
