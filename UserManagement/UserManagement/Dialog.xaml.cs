using Microsoft.Win32;
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
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog()
        {
            InitializeComponent();
        }



        private void btnopen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.DefaultExt = ".txt";
            ofd.Filter = "TextFile(.txt)|.txt|All Files(.)|.";
            if (ofd.ShowDialog() == true)
            {
                string filepath = ofd.FileName;
                txtfilename.Text = filepath;
                txtcontent.Text = File.ReadAllText(filepath);
            }
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save My file";
            sfd.DefaultExt = ".txt";
            sfd.Filter = "TextFile(.txt)|.txt|All Files(.)|.";
            if (sfd.ShowDialog() == true)
            {
                string filepath = sfd.FileName;
                txtfilename.Text = filepath;
                File.WriteAllText(filepath, "Hello welcome,JSQUARE");
                MessageBox.Show("File Saved");


            }
        }
    }
}

            
        
    

