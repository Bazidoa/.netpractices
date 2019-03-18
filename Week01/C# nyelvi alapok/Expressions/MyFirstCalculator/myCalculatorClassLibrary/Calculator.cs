using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCalculatorClassLibrary
{
    public class Calculator
    {
        public int Adder (int a, int b)
        {
            return a + b;
        }
        public int Substracter(int a, int b)
        {
            return a - b;
        }
        public int Multiplier(int a, int b)
        {
            return a * b;
        }
        public double Divider(double a, double b)
        {
            return Math.Round(a / b, 2);
        }
    }
}
