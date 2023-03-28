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

namespace WpfCalcLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double CurrentValue;
        public double DisplayValue;
        public bool isAdd;
        public bool isSubtract;
        public bool isMultiply;
        public bool isDivide;
        public bool hasDecimal;
        public bool isOn;
        public double Multiple;
        public MainWindow()
        {
            InitializeComponent();

            isOn = false;

            OnButton.Click += OnButton_Click;

            //Number Buttons
            OneButton.Click += OneButton_Click;
            TwoButton.Click += TwoButton_Click;
            ThreeButton.Click += ThreeButton_Click;
            FourButton.Click += FourButton_Click;
            FiveButton.Click += FiveButton_Click;
            SixButton.Click += SixButton_Click;
            SevenButton.Click += SevenButton_Click;
            EightButton.Click += EightButton_Click;
            NineButton.Click += NineButton_Click;
            ZeroButton.Click += ZeroButton_Click;
            ZeroZeroButton.Click += ZeroZeroButton_Click;
            DecimalPointButton.Click += DecimalPointButton_Click;

            //Basic Actions
            AddButton.Click += AddButton_Click;
            SubtractButton.Click += SubtractButton_Click;
            MultiplyButton.Click += MultiplyButton_Click;
            DivideButton.Click += DivideButton_Click;

            EqualButton.Click += EqualButton_Click;
            CEButton.Click += CEButton_Click;

            CalcDisplayTextBox.IsReadOnly = true;

            if(isOn)
                CalcDisplayTextBox.Text = DisplayValue.ToString();

            InvalidateVisual();
        }

        private void DecimalPointButton_Click(object sender, RoutedEventArgs e)
        {
            if (!hasDecimal && isOn)
            { 
                DisplayValue += .0;
                hasDecimal = true;
                Multiple = 10;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isAdd && !isSubtract && !isMultiply && !isDivide && isOn)
            {
                UpdateCurrentValue();
                CurrentValue = DisplayValue;
                Reset();
                isDivide = true;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isAdd && !isSubtract && !isMultiply && !isDivide && isOn)
            {
                UpdateCurrentValue();
                CurrentValue = DisplayValue;
                Reset();
                isMultiply = true;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isAdd && !isSubtract && !isMultiply && !isDivide && isOn)
            {
                UpdateCurrentValue();
                CurrentValue = DisplayValue;
                DisplayValue = 0;
                Reset();
                isSubtract = true;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isAdd && !isSubtract && !isMultiply && !isDivide && isOn)
            {
                UpdateCurrentValue();
                CurrentValue = DisplayValue;
                DisplayValue = 0;
                Reset();
                isAdd = true;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }
        private void ZeroZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if(!hasDecimal)
                    DisplayValue *= 100;
                else
                    Multiple *= 100;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                    DisplayValue *= 10;
                else
                { 
                    Multiple *= 10;
                }
                DisplayValue += 0;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 9;
                }
                else
                { 
                    DisplayValue += 9 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 8;
                }
                else
                {
                    DisplayValue += 8 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 7;
                }
                else
                {
                    DisplayValue += 7 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 6;
                }
                else
                {
                    DisplayValue += 6 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 5;
                }
                else
                {
                    DisplayValue += 5 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 4;
                }
                else
                {
                    DisplayValue += 4 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 3;
                }
                else
                {
                    DisplayValue += 3 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 2;
                }
                else
                {
                    DisplayValue += 2 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                if (!hasDecimal)
                {
                    DisplayValue *= 10;
                    DisplayValue += 1;
                }
                else
                {
                    DisplayValue += 1 / Multiple;
                    Multiple *= 10;
                }
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }


        public void Reset()
        {
            DisplayValue = 0;
            hasDecimal = false;
            isAdd = false;
            isSubtract = false;
            isMultiply = false;
            isDivide = false;
            Multiple = 0;
        }

        private void CEButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                Reset();
                CurrentValue = 0;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                UpdateCurrentValue();
                Reset();
                DisplayValue = CurrentValue;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }

        public void UpdateCurrentValue()
        {
            if(isAdd)
            {
                CurrentValue += DisplayValue;
                isAdd = false;
            }
            else if(isSubtract)
            {
                CurrentValue -= DisplayValue;
                isSubtract = false;
            }
            else if(isMultiply)
            {
                CurrentValue *= DisplayValue;
                isMultiply = false;
            }
            else if(isDivide)
            {
                if(DisplayValue != 0)
                {
                    CurrentValue /= DisplayValue;
                }
                else
                {
                    CalcDisplayTextBox.Text = "ERROR";
                    DisplayValue = 0;
                }
                isDivide = false;
            }

        }

        private void OnButton_Click(object sender, RoutedEventArgs e)
        {
            if (isOn)
            {
                isOn = false;
                CalcDisplayTextBox.Text = string.Empty;
            }
            else
            {
                isOn = true;
                Reset();
                CurrentValue = 0;
                CalcDisplayTextBox.Text = DisplayValue.ToString();
            }
        }
    }
}
