using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("°C: ");
            string myCelsius = Console.ReadLine();

            int myCelsiusInt = int.Parse(myCelsius);

            double myKelvin = myCelsiusInt + 273.15;
            Console.WriteLine($"It's " + myKelvin + " Kelvin atm.");
            double myFahr = myCelsiusInt*9d/5.0 +32;
            Console.WriteLine($"It's " +myFahr + " Fahrenheit atm" );


        }
    }
}
