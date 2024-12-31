using System.Reflection.Metadata;
using System.Windows;
using System.Windows.Controls;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for oops_concept.xaml
    /// </summary>
    public partial class oops_concept : Window
    {
        string firstnumber = "";
        string secondnumber = "";
        string oper = "";
        Decimal result = 0;
        string output = "";
        public oops_concept()
        {
            InitializeComponent();
        }


        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;


            if (oper == "")
            {
                firstnumber = firstnumber + button.Content;
                output = firstnumber;
                txtresult.Text = output;
            }
            else
            {
                secondnumber = secondnumber + button.Content;
                output = firstnumber + oper + secondnumber;
                txtresult.Text = output;
            }
        }

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {

            common ocommon = new common();


            ///<Summary>
            ///Calculatore progaram convert string to int 
            ///firstnumber
            ///</Summary>
            int first = convertint(firstnumber);

            ///<Summary>
            ///Calculatore progaram convert string to int 
            ///secondnumber
            ///</Summary>
            int second = convertint(secondnumber);

            output = output + "=\n";


            if (oper == "+")
            {
                ///<Summary>
                ///Calculatore progaram adding 2 numbers
                ///Firstnumber Secondnumber
                ///</Summary>
                
                result = ocommon.Add_number(first, second);
            }
            else if (oper == "-")
            {
                ///<Summary>
                ///Calculatore progaram subtracting 2 numbers
                ///Firstnumber Secondnumber
                ///</Summary>
                
                result = ocommon.Sub_number(first, second);
            }
            else if (oper == "*")
            {
                ///<Summary>
                ///Calculatore progaram multiplying 2 numbers
                ///Firstnumber Secondnumber
                ///</Summary>
                
                result = ocommon.Mul_number(first, second);
            }
            else if (oper == "/")
            {
                ///<Summary>
                ///Calculatore progaram dividing 2 numbers
                ///Firstnumber Secondnumber
                ///</Summary>
                
                result = ocommon.Div_number(first, second);
            }
            output = output + result.ToString();
            txtresult.Text = output;
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = "";
            secondnumber = "";
            oper = "";
            txtresult.Text = "";
            result = 0;
            output = "";

        }

        private void btnbackspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtresult.Text != "")
            {
                txtresult.Text = txtresult.Text.Substring(0, txtresult.Text.Length - 1);
                if (firstnumber != "")
                {
                    if (oper != "")
                    {
                        if (secondnumber != "")
                        {
                            secondnumber = secondnumber.Substring(0, secondnumber.Length - 1);
                        }
                        else
                        {
                            oper = oper.Substring(0, oper.Length - 1);
                        }
                    }
                    else
                    {
                        firstnumber = firstnumber.Substring(0, firstnumber.Length - 1);
                    }
                }
                else
                {

                }

            }
        }

        public int convertint(String firstnumber)
        {
            int firstint = 0;
            if (String.IsNullOrWhiteSpace(firstnumber) == false)
            {
                firstint = Convert.ToInt32(firstnumber);
            }
            return firstint;
        }

        private void btnoper_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            oper = button.Content.ToString();
            output = output + oper;
            txtresult.Text = output;
        }
    }
}
