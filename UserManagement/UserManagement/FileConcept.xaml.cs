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
using System.IO;

namespace UserManagement
{
    /// <summary>
    /// Interaction logic for FileConcept.xaml
    /// </summary>
    public partial class FileConcept : Window
    {
        public FileConcept()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            File.Create(txtpathfile.Text + txtfilename.Text);
            MessageBox.Show("File created succesfuly");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //if (File.Exists("C:\\jsfiles\\" + txtfilename.Text))
            MessageBoxResult val = MessageBox.Show("Are you sure want to delete?", "JS", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);



            if (File.Exists(txtpathfile.Text))
            {
                File.Delete(txtpathfile.Text);
                MessageBox.Show("delete file succesfuly");
            }
            else
            {
                MessageBox.Show("File Not exists");
            }
        }

        private void btnwrite_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(txtpathfile.Text, txtwritefile.Text);
            MessageBox.Show("Write data succesfuly");
        }

        private void btnread_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(txtpathfile.Text))
            {
                txtreadfile.Text = File.ReadAllText(txtpathfile.Text);
            }
            else
            {
                MessageBox.Show("File Not exists");
            }
        }

        private void btncreatefolder_Click(object sender, RoutedEventArgs e)
        {
            Directory.CreateDirectory(txtpathfile.Text);
            MessageBox.Show("Create Folder succesfuly");

        }

        private void btncheckfolder_Click(object sender, RoutedEventArgs e)
        {
            if(Directory.Exists(txtpathfile.Text))
            {
                MessageBox.Show("Yes folder is there");
            }
            else
            {
                MessageBox.Show("No folder is not there");
            }
        }

        private void btndeletefolder_Click(object sender, RoutedEventArgs e)
        {
            Directory.Delete(txtpathfile.Text);
            MessageBox.Show("Delete Folder succesfuly");

        }

        private void btndisplay_Click(object sender, RoutedEventArgs e)
        {
            string[] listfile = Directory.GetFiles(txtpathfile.Text);
            lstdisplay.ItemsSource = listfile;
        }
    }

}
