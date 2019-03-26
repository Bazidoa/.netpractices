using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizsgaraKeszules;
using Szamolos;

namespace DefaultStuffApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultStuff myDefaultStuff = new DefaultStuff();

            Console.WriteLine($"Default for int: {myDefaultStuff.Szam}");
            Console.WriteLine($"Default for string: {myDefaultStuff.Szoveg}");
            Console.WriteLine($"Default for bool: {myDefaultStuff.IgazHamis}");
            Console.WriteLine($"Default for DateTime: {myDefaultStuff.Idopont}");
            myDefaultStuff.Szam = 10;
            Console.WriteLine(myDefaultStuff.Szam);

            Console.WriteLine($"DateTime.Now: {DateTime.Now}");
            Console.WriteLine($"DateTime.Today: {DateTime.Today}");

            Numbers myNumber = new Numbers();
            Console.WriteLine(myNumber.GetNumbersBetween(1,1000));
            DateTime defTime = default(DateTime);
            Console.WriteLine(defTime);
            Console.ReadKey();
            new Numbers();
        }
    }
}
