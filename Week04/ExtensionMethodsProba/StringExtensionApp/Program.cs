using ExtensionMethodsProba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtensionMetodProbaforString firstExt = new ExtensionMetodProbaforString("Ez egy szöveg", 'e');

            Console.WriteLine(  firstExt.myText.CharCounter(firstExt.myChar));

        }
    }
}
