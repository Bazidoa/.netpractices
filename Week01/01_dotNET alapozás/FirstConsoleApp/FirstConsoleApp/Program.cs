using SecondClassLibrary;
using FirstClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + new Formatter().FormatName(name) + "!");
            // Console.ReadLine();

            Console.WriteLine("Hello lowercased " + new NameToLower().NameToLowerCase(name) + "!");
        }
    }
}
