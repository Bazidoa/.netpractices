using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum Regions : byte { North=1, East, South, West };
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(  Enum.GetValues(typeof(Regions))); //típusát kiírja a Regions-nak
            foreach (var item in Enum.GetValues(typeof(Regions)))
            {
                Console.WriteLine((byte)item);
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
        }
    }

}
