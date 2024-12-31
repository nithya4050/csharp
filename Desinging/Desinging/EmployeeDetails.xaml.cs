using System.Windows;
using Desinging.Model;
using System.Collections.Generic;
using System;


namespace Desinging
{
    /// <summary>
    /// Interaction logic for EmployeeDetails.xaml
    /// </summary>
    public partial class EmployeeDetails : Window
    {

        List<Employee> employees;
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtusername.Text) || String.IsNullOrEmpty(txtpassword.Text) || String.IsNullOrEmpty(txtdateofbirth.Text) || String.IsNullOrEmpty(txtage.Text) || String.IsNullOrEmpty(txtemailid.Text) || String.IsNullOrEmpty(txtphoneno.Text))
            {
                MessageBox.Show("Please fill all data");
            }
            else
            {
                if (employees == null)
                {
                    employees = new List<Employee>();
                }
                int empno = employees.Count + 1;
                int age = Convert.ToInt16(txtage.Text);

                employees.Add(new Employee { Empno = empno, Username = txtusername.Text, Password = txtpassword.Text, Age = age, Dateofbirth = txtdateofbirth.Text, Emailid = txtemailid.Text, PhoneNo = txtphoneno.Text });
                lstemplyeedetails.ItemsSource = null;
                lstemplyeedetails.ItemsSource = employees;
            }

        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            
            txtusername.Text = "";
            txtpassword.Text ="";
            txtage.Text = "";
            txtdateofbirth.Text = "";
            txtphoneno.Text = "";
            txtemailid.Text = "";
        }

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lstemplyeedetails_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Employee emp = lstemplyeedetails.SelectedItem as Employee;
            if(emp != null)
            {
                int empno = emp.Empno;
                txtusername.Text = emp.Username;
                txtpassword.Text = emp.Password;
                txtage.Text = Convert.ToString(emp.Age);
                txtdateofbirth.Text = emp.Dateofbirth;
                txtphoneno.Text = emp.PhoneNo;
                txtemailid.Text = emp.Emailid;
            }
          
        }
    }
}
