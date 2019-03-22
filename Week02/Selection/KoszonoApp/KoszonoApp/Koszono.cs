using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoszonoApp
{
    public class Koszono
    {
        public string SaySomeKindOfGreeting(int hour, int minutes)
        {
            string result ="";

            if (hour > 5)
            {
                result = "Jó reggelt!";
            }
            if (hour > 9)
            {
                result = "Jó napot!";
            }
            if (hour >= 18 && minutes > 30)
            {
                result = "Jó estét";
            }
            if (hour > 20)
            {
                result = "Jó éjt";
            }

            return result;
        }
    }
}
