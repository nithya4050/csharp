using System.Windows;
using CollectionsWPF.Model;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for LINQ_Lamendaworkout.xaml
    /// </summary>
    public partial class LINQ_Lamendaworkout : Window
    {

        List<Employee> employees;

        List<Employee> employees1;

        public LINQ_Lamendaworkout()
        {
            InitializeComponent();

            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = path + "//EmployeeDetails" + "//Employee.txt";

            if (File.Exists(path))
            {
                string userdata = File.ReadAllText(path);
                employees = JsonConvert.DeserializeObject<List<Employee>>(userdata);

            }
            lstemplyeedetails.ItemsSource = employees;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {

            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = path + "//EmployeeDetails" + "//Employee.txt";
            if (File.Exists(path))
            {
                string userdata = File.ReadAllText(path);
                employees = JsonConvert.DeserializeObject<List<Employee>>(userdata);



                if (rdblinq.IsChecked == true)
                {






                    if (cmbsearchtype.Text == "ALL")
                    {

                        if (rdblinq.IsChecked == true)
                        {
                            var list = from emp in employees

                                       select emp;

                            lstemplyeedetails.ItemsSource = null;
                            lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }


                    }
                   else if (cmbsearchtype.Text == "Ascending EMPNO")
                    {

                        if (rdblinq.IsChecked == true)
                        {
                                       var list = from emp in employees
                                       where emp.Username != null
                                       orderby emp.Username ascending
                                       select new { emp.Username, emp.Empno };

                                      lstemplyeedetails.ItemsSource = null;
                                      lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }

                        
                    }
                    else if (cmbsearchtype.Text == "Descending EMPNO")
                    {
                        if (rdblinq.IsChecked == true)
                        {
                            var list = from emp in employees
                                       where emp.Username != null
                                       orderby emp.Username descending
                                       select new { emp.Username, emp.Empno };

                            lstemplyeedetails.ItemsSource = null;
                            lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }
                    }
                   
                    else if (cmbsearchtype.Text == "Groupby AGE")
                    {
                        if (rdblinq.IsChecked == true)
                        {
                            var list = from emp in employees
                                       where emp.Username != null
                                       group emp by emp.Age.ToString();


                            lstemplyeedetails.ItemsSource = null;
                            lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }
                    }
                    else if (cmbsearchtype.Text == "EvenNumber EMPNO")
                    {
                        if (rdblinq.IsChecked == true)
                        {
                            var list = from emp in employees
                                       where ((emp.Empno) % 2) == 0
                                       orderby emp.Age ascending
                                       select emp;


                            lstemplyeedetails.ItemsSource = null;
                            lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }
                    }
                    else if (cmbsearchtype.Text == "OddNumber EMPNO")
                    {
                        if (rdblinq.IsChecked == true)
                        {
                            var list = from emp in employees
                                       where ((emp.Empno) % 2) != 0
                                       orderby emp.Age ascending
                                       select emp;


                            lstemplyeedetails.ItemsSource = null;
                            lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }
                    }
                    else if (cmbsearchtype.Text == "AGE GreaterThan 18")
                    {
                        if (rdblinq.IsChecked == true)
                        {
                            var list = from emp in employees
                                   where emp.Age > 18
                                   orderby emp.Age ascending
                                   select emp;


                        lstemplyeedetails.ItemsSource = null;
                        lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }
                    }
                    else if (cmbsearchtype.Text == "AGE LessThan 18")
                    {
                        if (rdblinq.IsChecked == true)
                        {
                            var list = from emp in employees
                                   where emp.Age < 18
                                   orderby emp.Age ascending
                                   select emp;


                        lstemplyeedetails.ItemsSource = null;
                        lstemplyeedetails.ItemsSource = list.ToList();
                        }
                        else
                        {
                            var list = employees.Where(emp => emp.Username != null).ToList();
                        }
                    }
                }

               
            }
        }
    }
}
