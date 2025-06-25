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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double firstNumber;
        public double secondNumber;
        public string operation;
        public bool operationClick;
        public MainWindow()
        {
            InitializeComponent();
            operationClick = false;
        }

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 7;
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 8;
        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 9;
        }

        private void FourBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 4;
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 5;
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 6;
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 1;
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 2;
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 3;
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            Input.Clear();
            operationClick = false;
        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationClick)
            {
                Input.Text = "";
                operationClick = false;
            }
            Input.Text += 0;
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                firstNumber = double.Parse(Input.Text);
                operation = "/";
                operationClick = true;
            }
        }

        private void MultiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                firstNumber = double.Parse(Input.Text);
                operation = "*";
                operationClick = true;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                firstNumber = double.Parse(Input.Text);
                operation = "-";
                operationClick = true;
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                firstNumber = double.Parse(Input.Text);
                operation = "+";
                operationClick = true;
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text) && !string.IsNullOrEmpty(operation))
            {
                secondNumber = double.Parse(Input.Text);
                double result = 0;
                switch (operation)
                {
                    case "/":
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                        }
                        else MessageBox.Show("Error");
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                }
                Input.Clear();
                Input.Text = result.ToString();
                operationClick = true;
            }
        }
    }
}
