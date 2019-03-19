using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
   public class Gentleman
    {
        public string SayHello(string name)
        {
            string Greeting = $"Hello " + name;
            return Greeting;         
        }
    }
}
