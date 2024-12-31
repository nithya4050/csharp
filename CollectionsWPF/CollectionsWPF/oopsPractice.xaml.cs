using System.Windows;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for oopsPractice.xaml
    /// </summary>
    public partial class oopsPractice : Window
    {
        public oopsPractice()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            common ocommon = new common();
            int mark1 = 0;
            int mark2 = 0;
            int mark3 = 0;
            int mark4 = 0;
            int mark5 = 0;

            int count_mark = 0;
           
            clear();

            if (!string.IsNullOrEmpty(txttamil.Text))
            {
                /// <summary>
                /// convert string to integer Tamil mark
                /// </summary>
                /// 
                mark1 = convertint(txttamil.Text);
                count_mark = count_mark + 1;
            }
            else
            {
                lbltamil.Content = "Absent";
            }
            if (!string.IsNullOrEmpty(txtenglish.Text))
            {
                /// <summary>
                /// convert string to integer English mark
                /// </summary>
                /// 
                mark2 = convertint(txtenglish.Text);
                count_mark = count_mark + 1;
            }
            else
            {

                lblenglish.Content = "Absent";
            }

            if (!string.IsNullOrEmpty(txtmaths.Text))
            {
                /// <summary>
                /// convert string to integer maths mark
                /// </summary>
                /// 
                mark3 = convertint(txtmaths.Text);
                count_mark = count_mark + 1;
            }
            else
            {
                lblmaths.Content = "Absent";
            }
            if (!string.IsNullOrEmpty(txtscience.Text))
            {
                /// <summary>
                /// convert string to integer science mark
                /// </summary>
                /// 
                mark4 = convertint(txtscience.Text);
                count_mark = count_mark + 1;
            }
            else
            {
                lblscience.Content = "Absent";
            }


            if (!string.IsNullOrEmpty(txtsocialscience.Text))
            {
                /// <summary>
                /// convert string to integer social mark
                /// </summary>
                
                mark5 = convertint(txtsocialscience.Text);
                count_mark = count_mark + 1;
            }
            else
            {
                lblsocial.Content = "Absent";
            }
            int result = ocommon.Five_Marks(mark1, mark2, mark3, mark4, mark5);
            txttotal.Text = result.ToString();

            if (count_mark == 5)
            {
               
                lblcongradulation.Content = "Congradulation " + txtblkname.Text + " Your total score is  " + result.ToString();
            }
            else if (count_mark == 0)
            {
                lblcongradulation.Content = "Sorry " + txtblkname.Text + " Your total score is " + " " + result.ToString();
            }
            /// <summary>
            /// Adding five marks
            /// </summary>


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

        public void clear()
        {
            lblcongradulation.Content = "";
            lblenglish.Content = "";
            lblmaths.Content = "";
            lblscience.Content = "";
            lblsocial.Content = "";
            lbltamil.Content = "";
            
        }

        public void Clear_textbox()
        {
            txtenglish.Text = "";
            txtmaths.Text = "";
            txtscience.Text = "";
            txtsocialscience.Text = "";
            txttamil.Text = "";
            txttotal.Text = "";
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            clear();
            Clear_textbox();
        }
    }
}
