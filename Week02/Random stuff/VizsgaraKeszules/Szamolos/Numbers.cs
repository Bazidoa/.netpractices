using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamolos
{
    public class Numbers
    {
        public string GetNumbersBetween(int min, int max)
        {
            string result ="";
            for (int i = min+1; i < max; i++)
            {
                result = result +" "+ i.ToString();
            }
            return result;    
        }
    }
}
