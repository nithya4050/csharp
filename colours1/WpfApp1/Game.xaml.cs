using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        bool start = false;
        int count;
        public Game()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            if (start == true)
            {
                if (count < 3)
                {
                    Button btn = (Button)sender;
                    btn.Content = btn.Tag;
                    btn.Background = Brushes.Blue;
                    if (btn.Background == Brushes.Blue)
                    {
                        count = count + 1;
                        btn.IsEnabled = false;
                    }

                    long value = Convert.ToInt16(lblscore.Content);
                    value = value + Convert.ToInt16(btn.Tag);
                    lblscore.Content = value;
                }
                else
                {
                    //MessageBox.Show("You have only three chance,Please Try Again");
                    MessageBox.Show("Game Over your score is " + lblscore.Content);
                    start = false;
                    lblscore.Content = 0;
                }

            }
            else
            {
                MessageBox.Show("Click start button for start game");
            }
        }

        private void btnstart_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            start = true;
            MessageBox.Show("Game Start! select your lucky Box");
        }

        private void btnend_Click(object sender, RoutedEventArgs e)
        {
            if (start == true)
            {
                MessageBoxResult msg = MessageBox.Show("Are you sure want to quit your game?", "Jsquare Game", MessageBoxButton.YesNo);
                if (msg == MessageBoxResult.Yes)
                {
                    start = true;

                    // MessageBox.Show("Game Over your score is " + lblscore.Content);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Game over! Your total score is");
                    sb.Append(lblscore.Content);
                    MessageBox.Show(sb.ToString());
                }
                start = false;
                lblscore.Content = 0;
            }
            else
            {
                MessageBox.Show("Please click start before end the game");

            }

        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            UIElementCollection buttons = mystackpanel.Children;
            int count = buttons.Count;

            for (int i = 0; i < count; i++)
            {
                if (buttons[i] is Button)
                {
                    Button btn = (Button)buttons[i];
                    object val = btn.Tag;
                    //object val1 = btn.Content;
                    //btn.Content = val1;
                    object ncontentvalue = btn.Content;
                    btn.IsEnabled = true;
                    btn.Background = Brushes.Gold;
                }

            }
            start = false;
            lblscore.Content = 0;
        }
    }
}
