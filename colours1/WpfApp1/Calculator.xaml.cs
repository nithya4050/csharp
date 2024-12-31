using System.Diagnostics.Eventing.Reader;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {

        string firstnumber = "";
        string secondnumber = "";
        string oper = "";
        Decimal result = 0;
        string output = "";

        public Calculator()
        {
            InitializeComponent();
        }
      


        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;
           
            
           if (oper == "")
            {
                firstnumber = firstnumber + button.Content;
                output = firstnumber;
                txtresult.Text = output;
            }
            else 
            {
                //if(secondnumber == "")
                //{
                //  output =  output + "\n";
                //}

                secondnumber = secondnumber + button.Content;
                //string secno1 = secondnumber;

                output = firstnumber + oper +secondnumber;
                //string secno = secondnumber;
                txtresult.Text = output;
            }
        }

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            
            Decimal first = Convert.ToDecimal(firstnumber);
            Decimal second = Convert.ToDecimal(secondnumber);
            output = output + "=\n";


            if (oper == "+")
            {
                result = first + second;
            }
            else if (oper == "-")
            {
                result = first - second;
            }
            else if (oper == "*")
            {
                result = first * second;
            }
            else if(oper == "/")
            {
                result = first / second;
            }
            output = output + result.ToString();
            //txtresult.Text = Convert.ToString(result.ToString());
            //output = output + "=\n";
            txtresult.Text = output;
        }
        private void btnoper_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            oper = button.Content.ToString();
            output = output + oper;
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


        //private void btn2_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();

        //    if (oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "2";
        //    }
        //    else if (oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "2";
        //    }
        //}

        //private void btn3_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();

        //    if (oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "3";
        //    }
        //    else if (oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "3";
        //    }
        //}




        //private void btn4_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();

        //    if (oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "4";
        //    }
        //    else if (oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "4";
        //    }
        //}

        //private void btn5_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();
        //    if (oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "5";
        //    }
        //    else if (oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "5";
        //    }
        //}

        //private void btn6_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();
        //    if(oper =="")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "6";
        //    }
        //    else if(oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "6";
        //    }
        //}

        //private void btnminus_Click(object sender, RoutedEventArgs e)
        //{
        //    lbloperator.Content = "-";
        //}

        //private void btn7_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();
        //    if(oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "7";
        //    }
        //    else if(oper !="")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "7";
        //    }
        //}

        //private void btn8_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();
        //    if(oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "8";
        //    }
        //    else if(oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "8";
        //    }
        //}

        //private void btn9_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();
        //    if(oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "9";
        //    }
        //    else if(oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "9";
        //    }

        //}

        //private void btnmul_Click(object sender, RoutedEventArgs e)
        //{
        //    lbloperator.Content = "*";
        //}



        //private void btnzero_Click(object sender, RoutedEventArgs e)
        //{
        //    string oper = lbloperator.Content.ToString();

        //    if (oper == "")
        //    {
        //        txtfirstno.Text = txtfirstno.Text + "0";
        //    }
        //    else if (oper != "")
        //    {
        //        txtsecondno.Text = txtsecondno.Text + "0";
        //    }
        //}



        //private void btndiv_Click(object sender, RoutedEventArgs e)
        //{
        //    lbloperator.Content = "/";
        //}
    }
}
