using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {

            // Stingek összefűzése több módszerrel

            //sima összefűzés, nem ajánlott, memória szeméttel jár
            string str1 = "1";
            string str2 = "2";

            string str3 = str1 + str2;
            Console.WriteLine(str3);

            str3 = "uritem";
            Console.WriteLine(str3);

            // interpretált strig összefűzés, nem olyan rossz, de még nem az igazi
            str3 = $"{str2} {str1}";
            Console.WriteLine(str3);

            str3 = "uritem";
            Console.WriteLine(str3);

            // stringbuilder típussal tudok .Append() .Replace() .Remove() a végén viszont kell egy ToString();
            StringBuilder strBTemp = new StringBuilder();

            strBTemp.Append(str1);
            strBTemp.Append(str2);
            str3 = strBTemp.ToString();
            Console.WriteLine(str3);


            string titleUpper = "title".ToUpper();
            Console.WriteLine(titleUpper);


            int amountBefore = 10000;

            Random randObject = new Random();
            int rand = randObject.Next(1, amountBefore);
            Console.WriteLine(rand);

            int amountAfter = amountBefore-rand;

            StringBuilder myStringBuilder = new StringBuilder("A kiinduló pénzed:");
            myStringBuilder.Append(amountBefore);
            myStringBuilder.Append("-Ft. Ennyid maradt: ");
            myStringBuilder.Append(amountAfter);
            myStringBuilder.Append("Ft. Összesen ");
            myStringBuilder.Append(rand);
            myStringBuilder.Append(" Ft-ot költöttél.");

            string myString = myStringBuilder.ToString();
            Console.WriteLine(myString);

            
           /* 10 random szám létrehozása
            for (int i = 0; i < 10; i++)
            {
                double randomNumber = rand1.Next();
                Console.WriteLine(randomNumber);
            }
            */
            
        }
    }
}
