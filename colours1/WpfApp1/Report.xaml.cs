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
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnaccept_Click(object sender, RoutedEventArgs e)
        {
           
           



            string html = $" <p> Subject: <b> Job offer </b> -  {txtpositionname.Text},\r\n\r\n Dear {txtname.Text}, \r\n\r\n We are pleased to offer you the possition of {txtpositionname.Text} at {txtcompanyname.Text}. Your start date will be {txtstartdate.Text},\r\n and your annual salary will be {txtsalary.Text} with benefits as outlined in the attached document.\r\n Please review the terms and confirm your acceptance by {txtstartdate.Text}.\r\n\r\n we look forward to welcoming you to the team!\r\n\r\n Best regards,\r\n\r\n {txthrname.Text} \r\n {txthrposition.Text} \r\n {txtcompanyname.Text} </p>";



            web.NavigateToString(html);
            
            //string wel = "Subject: Job offer - [PositionName] Hi \t\t\t\t Dear [CandidateName],\r\n\r\n We are pleased to offer you the possition of [PositionName] at [CompanyName]. Your start date will be [StartDate],\r\n and your annual salary will be [SalaeryAmount], with benefits as outlined in the attached document.\n\r\n Please review the terms and confirm your acceptance by [AcceptanceDeadline].\r\n\r\n we look forward to welcoming you to the team!\r\n\r\n Best regards,\r\n\r\n[HrName]\r\n[HrPositoin]\r\n[CompanyName]";

            //string output = string.Format("Subject: Job offer - {0} Hi \r\n\r\n Dear Mr{1} \r\n\r\n We are pleased to offer you the");
            ////ing wel = "Subject: Job offer - [PositionName] Hi \t\t\t\t Dear [CandidateName],\r\n\r\n We are pleased to offer you the possition of [PositionName] at [CompanyName]. Your start date will be [StartDate],\r\n and your annual salary will be [SalaeryAmount], with benefits as outlined in the attached document.\n\r\n Please review the terms and confirm your acceptance by [AcceptanceDeadline].\r\n\r\n we look forward to welcoming you to the team!\r\n\r\n Best regards,\r\n\r\n[HrName]\r\n[HrPositoin]\r\n[CompanyName]";

            ////string output = $"Subject: Job offer -  {txtpositionname.Text},\r\n\r\n Dear {txtname.Text}, \r\n\r\n We are pleased to offer you the possition of {txtpositionname.Text} at {txtcompanyname.Text}. Your start date will be {txtstartdate.Text},\r\n and your annual salary will be {txtsalary.Text} with benefits as outlined in the attached document.\r\n Please review the terms and confirm your acceptance by {txtstartdate.Text}.\r\n\r\n we look forward to welcoming you to the team!\r\n\r\n Best regards,\r\n\r\n {txthrname.Text} \r\n {txthrposition.Text}\r\n{txtcompanyname.Text}";
            ////txtoffername.Text = output;


            //wel = wel.Replace("[PositionName]", txtpositionname.Text);
            //wel = wel.Replace("[CandidateName]", txtname.Text);
            //wel = wel.Replace("[CompanyName]", txtcompanyname.Text);
            //wel = wel.Replace("[PositionName]", txtpositionname.Text);
            //wel = wel.Replace("[StartDate]", txtstartdate.Text);
            //wel = wel.Replace("[SalaeryAmount]", txtsalary.Text);
            //wel = wel.Replace("[AcceptanceDeadline]", txtstartdate.Text);
            //wel = wel.Replace("[HrName]", txthrname.Text);
            //wel = wel.Replace("[HrPositoin]", "HR Manager");
            //wel = wel.Replace("[CompanyName]", txtcompanyname.Text);
            //toffername.Text = wel;



        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clear");
        }

        private void txtdescription_TextChanged(object sender, TextChangedEventArgs e)
        {
        lbllength.Content =$"your remaining text length {250 - txtdescription.Text.Length} /250";
        if(txtdescription.Text.Length > 50)
            {
                lbllength.Foreground = Brushes.Red;
            }
        }

        private void btnloop_Click(object sender, RoutedEventArgs e)
        {

            // syntax for for loop
            //for(; ;)
            //{
            // it execute infinity times
            //}

            int i= 1;
            for(; i< 5;)
            {

                i++;
            }

            int i3 = 0;
            for (; ;)
            {
                i3++;
                MessageBox.Show(i3.ToString());
                if(i3 >5)
                {
                    break;
                }
            }

            for(int i1 = 0; i1 < 5; i1++)
            {
                MessageBox.Show(i1.ToString());
            }

            // string sname only have pavithra.
            String sname = "Pavithra";
            MessageBox.Show(sname.ToString());

            // More than one data means use array.

            String[] names = { "Selvam", "Pooja", "Nithya", "Ayesha" };
            MessageBox.Show(names[0].ToString());
            MessageBox.Show(names[1].ToString());
            MessageBox.Show(names[2].ToString());
            MessageBox.Show(names[3].ToString());


            // length is to find array index value.
            // index position start from 0.
            int count = names.Length;

            // using for loop we get more data
            for (int i2 = 0; i2 < count; i2++)
            {
                MessageBox.Show(names[i2].ToString());
            }


        }
    }






}
