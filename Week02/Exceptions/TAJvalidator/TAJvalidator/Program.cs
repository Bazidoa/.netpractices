using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAJvalidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient firstPatient = new Patient();
            try
            {
                firstPatient.YearOfBirth = 2000;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }

            firstPatient.SocialSecurityNumber = "012345678";

            Console.ReadKey();
        }
    }
}
