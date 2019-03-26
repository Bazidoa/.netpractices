using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a year, I'll tell you if it's a leap year or not.");
            string leapYear = Console.ReadLine();
            int leapYearInt = int.Parse(leapYear);

            bool isLeap = ((leapYearInt % 4 == 0) & (leapYearInt % 100 != 0 )) | leapYearInt % 400 ==0 ? true : false;

            Console.WriteLine(isLeap);

            


        }
    }
}
