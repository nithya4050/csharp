using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
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
using System.Xml.Linq;

namespace colours1
{
    /// <summary>
    /// Interaction logic for WinstringFunction.xaml
    /// </summary>
    public partial class WinstringFunction : Window
    {
        StringBuilder ss = new StringBuilder();
        public WinstringFunction()
        {
            InitializeComponent();
        }

        private void btnname_Click(object sender, RoutedEventArgs e)
        {
            string val = txtname.Text;

            int index = val.IndexOf("a");

            int lastindex = val.LastIndexOf("a");

            int firstindex = val.IndexOf("a");
            //string ss = Convert.ToString(index);
            //MessageBox.Show(ss);
            if (index > 0)
            {
                string second = val.Substring(index);
                MessageBox.Show(second);
                string first = val.Remove(index);
                MessageBox.Show(first);
            }
        }

        private void txtname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnchararray_Click(object sender, RoutedEventArgs e)
        {
            char[] val = txtname.Text.ToCharArray();
            string first = val[0].ToString().ToUpper();
            txtname.Text = txtname.Text.ToUpper();
            string remain = "";
            char[] name = txtname.Text.ToCharArray();
            if (name.Length > 0)
            {
                string first1 = name[0].ToString().ToUpper();
                if (name.Length > 1)
                {
                    remain = txtname.Text.Substring(1).ToLower();
                }
                txtname.Text = first + remain;

            }

        }

        private void txtpassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            string password = txtpassword.Text;
            int index = password.IndexOf("*");
            int password_length = password.Length;
            if (password_length > 8)
            {
                if (index > 0)
                {
                    lblvalidation.Foreground = Brushes.Green;
                    lblvalidation.Content = "Valid Password";
                }
                else if (index < 0)
                {
                    lblvalidation.Content = "InValid ! Password expect one *";
                }
            }
            else
            {
                lblvalidation.Content = "Passord expect 8 char one must *";
            }

        }

        private void txtnamemore_TextChanged(object sender, TextChangedEventArgs e)
        {
            string myname = txtnamemore.Text;
            int index = myname.IndexOf(" ");

            if (index > 0)
            {
                string split_name = myname.Substring(0, index);
                string[] split_name1 = myname.Split(" ");
                string split_name2 = split_name1[0];
                int split_length = split_name1.Length;
                for (int i = 1; i < split_length; i++)
                {
                    if (split_length > i)
                    {
                        char[] mysplit = split_name2.ToCharArray();
                        if (mysplit.Length > 0)
                        {
                            string first_char = mysplit[0].ToString().ToUpper();
                            string remain_name = split_name.ToString().Substring(1).ToLower();
                            //string final_name = first_char + remain_name;
                            //  MessageBox.Show(final_name);
                            ss.Append(first_char);
                            ss.Append(remain_name);
                            ss.Append("");
                            txtnamemore.Text = ss.ToString();
                        }
                    }

                }

            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
            {
                
                string[] names = txtnamemore.Text.Split(" ");
                //string split_name2 = names[0];
                //int index = names.IndexOf(" ");
                //string split_name = names.Substring(0, index);
                int count = names.Length;
                for (int i = 0; i < count; i++)
                {
                    if (names[i] != "")
                    {
                        string val = names[i].ToString();
                        string fir = val.Remove(1);
                        string capital_letter = fir.ToUpper();

                        string remain = val.Substring(1);
                        string lower_letter = remain.ToLower();


                        ss.Append(capital_letter);
                        ss.Append(lower_letter);
                        ss.Append(" ");
                    }
                    //string first_char = val.ToString().ToUpper();
                    //string remain_name = names[i].ToString().Substring(1).ToLower();
                    //string final_name = first_char + remain_name;
                    //ss.Append(final_name);
                }

                txtnamemore.Text = ss.ToString();
            }
        
    }

}
