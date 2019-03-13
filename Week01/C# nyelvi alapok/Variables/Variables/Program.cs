using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        /// <summary>
        /// Writes the values of given variables in the same line to the Console.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool b = false;
            Console.WriteLine(b);

            int a = 2;
            int x = 3, y = 4;
            //nem lehet definiálás előtt kiírni, obvi
            //Console.WriteLine(k); 
            int k = a;
            Console.WriteLine(a + " " + x + " " + y + " " + k);

            string s = "Hello World";
            string t = s;

            {
                int h = 0;
                Console.WriteLine("az h változó: "+h);
                Console.WriteLine("az a változó: "+a);
            }
        //Console.WriteLine(h); a blokkban létrehozott h változó itt már nem él
        }

    }
}
