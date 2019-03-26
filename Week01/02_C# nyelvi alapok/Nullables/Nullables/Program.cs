using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Are you satisfied? Please write 'yes' / 'no' or nothing");
            string answer = Console.ReadLine();
            bool? isSatisfiedCustomer = null;

            if (string.Compare(answer, "yes", true) == 0)
            {
                isSatisfiedCustomer = true;
                Console.WriteLine(isSatisfiedCustomer);
            }

            if (string.Compare(answer, "no", true) == 0)
            {
                isSatisfiedCustomer = false;
                Console.WriteLine(isSatisfiedCustomer);
            } 

            if (isSatisfiedCustomer != null)
            {
                Console.WriteLine(isSatisfiedCustomer.GetType());
            } else
            {
                Console.WriteLine("isSatisfiedCustomer is null, the customer didn't answer");
            }
            Console.WriteLine(isSatisfiedCustomer.HasValue);
            //Console.WriteLine(isSatisfiedCustomer.Value); --ha null akkor nem kezelt kivétel van, mert null-nak nem lehet lekérni a Value-ját


            //Int32 type lekérése
            int szam = 32;
            Console.WriteLine(szam.GetType());
        }

    }
}

