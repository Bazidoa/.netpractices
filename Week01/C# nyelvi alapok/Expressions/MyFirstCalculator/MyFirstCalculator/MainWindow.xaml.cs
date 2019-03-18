using myCalculatorClassLibrary;
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

namespace MyFirstCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculator calc = new Calculator();

            int firstNum = int.Parse(FirstNumberBox.Text);
            int secondNum = int.Parse(SecondNumberBox.Text);
            double guessNum = double.Parse(GuessBox.Text);
            double result = 0;
            string choosenOperator = myOperators.Text;

            switch (choosenOperator)
            {
                case "+":
                    result = calc.Adder(firstNum, secondNum);
                    break;
                case "-":
                    result = calc.Substracter(firstNum, secondNum);
                    break;
                case "*":
                    result = calc.Multiplier(firstNum, secondNum);
                    break;
                case "/":
                    double dfirstNum = firstNum * 10 / 10d;
                    double dsecondNum = secondNum * 10 / 10d;
                    result = calc.Divider(dfirstNum, dsecondNum);
                    break;
                    
            }
            //double tesztresult = (double)firstNum;
            //MessageBox.Show(tesztresult.ToString());
            if (result == guessNum)
            {
                MessageBox.Show($"Your guess " + GuessBox.Text +" was right.");
            }
            else
            {
                MessageBox.Show($"You guessed " + GuessBox.Text+ " wrongly. The correct answer is: " +result );
            }
        }


    }
}
