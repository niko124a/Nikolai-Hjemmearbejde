using System.Collections.Generic;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        string result;
        string mathChoise = "";
        List<int> inputs = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 0;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (mathChoise == "")
            {
                num1 = (num1 * 10) + 1;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                TextBox.Text = num2.ToString();
            }

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 2;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 3;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 4;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 5;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 6;
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 7;
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 8;
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += 9;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            mathChoise = "-";
        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            mathChoise = "+";
        }
    }
}
