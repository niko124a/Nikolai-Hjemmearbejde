using System;
using System.Collections.Generic;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<double> numbers = new List<double>();
        List<string> op = new List<string>();
        private string num = "";
        string operation = "";
        private double result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            num += "0";
            TextBox.Text = num;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            num += "1";
            TextBox.Text = num;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            num += "2";
            TextBox.Text = num;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            num += "3";
            TextBox.Text = num;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            num += "4";
            TextBox.Text = num;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            num += "5";
            TextBox.Text = num;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            num += "6";
            TextBox.Text = num;
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            num += "7";
            TextBox.Text = num;
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            num += "8";
            TextBox.Text = num;
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            num += "9";
            TextBox.Text = num;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            numbers.Add(Convert.ToDouble(num));
            operation = "-";
            op.Add(operation);
            num = "";
            operation = "";
            TextBox.Text = "0";
        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (num == "")
            {
                
            }
            else
            {
                numbers.Add(Convert.ToDouble(num));
                operation = "+";
                op.Add(operation);
                num = "";
                operation = "";
                TextBox.Text = "0";
            }
            
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            numbers.Add(Convert.ToDouble(num));
            operation = "*";
            op.Add(operation);
            num = "";
            operation = "";
            TextBox.Text = "0";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            numbers.Add(Convert.ToDouble(num));
            operation = "/";
            op.Add(operation);
            num = "";
            operation = "";
            TextBox.Text = "0";
        }

        public bool i = true;
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            if (i)
            {
                numbers.Add(Convert.ToDouble(num));
                i = false;
            }
            result = numbers[0];
            numbers.Remove(numbers[0]);
            while (op.Count != 0)
            {

                switch (op[0])
                {
                    case "+":
                        result += numbers[0];
                        break;
                    case "-":
                        result += numbers[0];
                        break;
                    case "*":
                        result += numbers[0];
                        break;
                    case "/":
                        result += numbers[0];
                        break;
                }

                numbers.Remove(numbers[0]);
                op.Remove(op[0]);

            }
            numbers.Add(result);
            num = "";
            TextBox.Text = result.ToString();
        }
        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num = "0";
            }
            TextBox.Text = "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            num = "0";
            operation = "";
            TextBox.Text = "0";
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void PositivNegativ_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
