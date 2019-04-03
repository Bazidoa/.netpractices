using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = new double[1000];
            for (int i = 0; i < 1000; i++)
            {
                Random myRandom = new Random();

                myArray[i] = myRandom.NextDouble() * 1000000;
                // Console.WriteLine("{0,8:N5}",myArray[i]);

            }

            double mySum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                mySum += myArray[i];

            }
            Console.WriteLine(mySum);
            double mySum2 = Math.Round(mySum);
            Console.WriteLine(mySum2);
            Console.ReadKey();

            for (int i = 0; i < myArray.Length; i++)
            {
                mySum = 0;
                mySum += Math.Round(myArray[i]);

            }
            Console.WriteLine(mySum);
            Console.ReadKey();
        }
    }
}
