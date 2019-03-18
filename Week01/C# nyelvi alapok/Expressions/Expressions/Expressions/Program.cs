using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 4 / 3;
            Console.WriteLine("my int");
            Console.WriteLine(myNum);

            //double myDouble = 4.0 / 3;
            double myDouble = 4d / 3;
            Console.WriteLine("my double");
            Console.WriteLine(myDouble);

            int yourNumber = int.Parse(Console.ReadLine());
            //bool isEven = false;
            //if (yourNumber % 2 == 0)
            //{
            //    isEven = true;
            //}
            //Console.WriteLine(isEven);

            bool isEven = yourNumber % 2 == 0;
            Console.WriteLine("iseven?");
            Console.WriteLine(isEven);

            int yourSecondNumber = int.Parse(Console.ReadLine());
            bool biggerThanTen = yourSecondNumber > 10; // if this statement is true, variable will be true
            Console.WriteLine("is bigger than 10?");
            Console.WriteLine(biggerThanTen);

            int i = 7;
            int j = i++;

            Console.WriteLine("i = "+i); // prints the incrementerd i value
            Console.WriteLine("j = "+j); // j gets the value of i, then its incremented

            Console.WriteLine("bool default value: "+typeof(bool));
            Console.WriteLine(i.GetType());

            Console.WriteLine(sizeof(long));

            string name = Console.ReadLine();
            
            bool ruBala = (name == "Bala") ?  true : false;
            Console.WriteLine(ruBala);

            string s = "Word";
            Console.WriteLine(s.ToUpper());

            string s2 = null;
            Console.WriteLine(s2?.ToUpper()); // a kérdőjel miatt megnézi, hogy null-e, ha igen, akkor nem hívja meeg a metódust, elkerüljük a reference errort
        }
    }
}
