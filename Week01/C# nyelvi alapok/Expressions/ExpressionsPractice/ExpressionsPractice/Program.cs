using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("John" + 4 + 4);
            Console.WriteLine(4+4+"John");

            int x = 5 + 6;
            int y = 11 - x;
            int z = 8;
            bool b = x>y ? true : false;
            bool c = b == true || z > 5 ? true : false;
            z++;

            Console.WriteLine($"b variable: " + b);
            Console.WriteLine($"c variable: " + c);



        }
    }
}
