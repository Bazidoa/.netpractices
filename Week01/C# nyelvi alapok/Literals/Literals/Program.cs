using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            double quotient = 3 / 4d;
            Console.WriteLine(quotient);
            // d suffix nélkül két intet oszt el egymással és az valóban 0. így viszont double eredményt ad 

            string imageFile = @"C:\\yellowroad\\images\\yellowroadlogo.png";
            string emailBody = @"Szia!\nMegkaptuk a jelentkezésedet.\nÜdv,\nYellowroad csapata";

            Console.WriteLine(imageFile);
            Console.WriteLine(emailBody);
        }
    }
}
