using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearInput = "1993";
            int year = Convert.ToInt32(yearInput);

            myTryDataLoss myProba = new myTryDataLoss();
            myProba.TryDataLoss();
        }
    }
}
