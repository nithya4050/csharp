using System.Windows;
using CollectionsWPF.Model;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Windows.Controls;


namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for EmployeeSearch.xaml
    /// </summary>
    public partial class EmployeeSearch : Window
    {

        List<Employee> employees;
        public EmployeeSearch()
        {

            InitializeComponent();
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = path + "//EmployeeDetails" + "//Employee.txt";
            if (File.Exists(path))
            {
                string userdata = File.ReadAllText(path);
                employees = JsonConvert.DeserializeObject<List<Employee>>(userdata);


                string ss = cmbsearchtype.Text;
                if (employees != null)
                {
                    if (cmbsearchtype.Text == "Empno")
                    {
                            var list = from emp in employees
                                   where emp.Empno == Convert.ToInt16(txtsearchyourdata.Text)
                                   select emp;
                                   lstemplyeedetails.ItemsSource = list;
                    }
                    else if(cmbsearchtype.Text == "UserName")
                    {
                             var list = from emp in employees
                                   where emp.Username == txtsearchyourdata.Text
                                   select emp;
                                  lstemplyeedetails.ItemsSource = list;
                    }
                    else if (cmbsearchtype.Text == "Password")
                    {
                               var list = from emp in employees
                                   where emp.Password == txtsearchyourdata.Text
                                   select emp;
                                   lstemplyeedetails.ItemsSource = list;
                    }
                    else if (cmbsearchtype.Text == "Age")
                    {
                            var list = from emp in employees
                                   where emp.Age == Convert.ToInt16(txtsearchyourdata.Text)
                                   select emp;
                                   lstemplyeedetails.ItemsSource = list;
                    }
                    else if (cmbsearchtype.Text == "Dateofbirth")
                    {
                            var list = from emp in employees
                                   where emp.Dateofbirth == txtsearchyourdata.Text
                                   select emp;
                                  lstemplyeedetails.ItemsSource = list;
                    }
                    else if (cmbsearchtype.Text == "Emailid")
                    {
                            var list = from emp in employees
                                   where emp.Emailid == txtsearchyourdata.Text
                                   select emp;
                                  lstemplyeedetails.ItemsSource = list;
                    }
                    else if (cmbsearchtype.Text == "ALL")
                    {
                        var list = from emp in employees
                                   select emp;
                        lstemplyeedetails.ItemsSource = list;
                    }
                    else if (cmbsearchtype.Text == "Contains")
                    {
                        var list = from emp in employees
                                   where emp.Username.Contains(txtsearchyourdata.Text)
                                   select emp;
                        lstemplyeedetails.ItemsSource = list;
                    }

                }

            }
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDetails employee = new EmployeeDetails();
            employee.ShowDialog();
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtsearchyourdata.Text = "";
        }
    }
}
