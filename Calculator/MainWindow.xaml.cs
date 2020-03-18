using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

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
        string operation = "";
        List<int> inputs = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10);
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                TextBox.Text = num2.ToString();
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
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
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                TextBox.Text = num2.ToString();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                TextBox.Text = num2.ToString();
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 4;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                TextBox.Text = num2.ToString();
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                TextBox.Text = num2.ToString();
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                TextBox.Text = num2.ToString();
            }
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                TextBox.Text = num2.ToString();
            }
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                TextBox.Text = num2.ToString();
            }
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                TextBox.Text = num2.ToString();
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            TextBox.Text = "0";
        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            TextBox.Text = "0";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            TextBox.Text = "0";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            TextBox.Text = "0";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    TextBox.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    TextBox.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    TextBox.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    TextBox.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = 0;
            }
            else
            {
                num2 = 0;
            }
            TextBox.Text = "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            TextBox.Text = "0";
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 / 10);
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 / 10);
                TextBox.Text = num2.ToString();
            }
        }

        private void PositivNegativ_OnClick(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 *= -1;
                TextBox.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                TextBox.Text = num2.ToString();
            }
        }
    }
}
