using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlapMuveletekLibrary
{
    public class MathCalculator
    {
        public double Calculate(double num1, double num2, string muveletiJel)
        {
            double result = 0;

            switch(muveletiJel){
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            return result;

        }
    }
}
