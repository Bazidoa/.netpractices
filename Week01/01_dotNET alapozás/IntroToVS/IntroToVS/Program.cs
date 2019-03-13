using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToVS
{
    // Ha cmd-ből meghívod akkor kiírja a paraméterek számát és a paramétereket.
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hello Yello!");

        Console.WriteLine(args.Length);
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine();
        }
        //Kiírja a megnyomott billentyűt
            Console.ReadKey();
        }
    }

}
