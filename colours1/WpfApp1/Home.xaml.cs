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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        
        public Home()
        {
            InitializeComponent();
        }

     
        

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt32(txtfirstno.Text);
            int second = Convert.ToInt32(txtsecondno.Text);

            int result = first + second;
            string result1 = Convert.ToString(result.ToString());
            txtresult.Text = Convert.ToString(result1);
        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {


            int first = Convert.ToInt32(txtfirstno.Text);
            int second = Convert.ToInt32(txtsecondno.Text);

            int result = first - second;
            string result1 = Convert.ToString(result.ToString());
            txtresult.Text = Convert.ToString(result1);

        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt32(txtfirstno.Text);
            int second = Convert.ToInt32(txtsecondno.Text);

            int result = first * second;
            string result1 = Convert.ToString(result.ToString());
            txtresult.Text = Convert.ToString(result1);

        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt32(txtfirstno.Text);
            int second = Convert.ToInt32(txtsecondno.Text);

            int result = first / second;
            string result1 = Convert.ToString(result.ToString());
            txtresult.Text = Convert.ToString(result1);
        }
    }
}
