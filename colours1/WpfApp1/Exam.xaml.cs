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
    /// Interaction logic for Exam.xaml
    /// </summary>
    public partial class Exam : Window
    {
        public Exam()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rbval = (RadioButton)sender;
            if(rbval.Tag.ToString() == "Y")
            {
                int Score_value = Convert.ToInt32(lblscore.Content);
                Score_value++;
                lblscore.Content = Score_value.ToString();
            }

            StackPanel stp = (StackPanel)rbval.Parent;
            int count = stp.Children.Count;
            for(int i= 0; i<count; i++)
            {
                RadioButton rbexam = (RadioButton)stp.Children[i];
                rbexam.IsEnabled = false;
                
            }
        }
    }

}
