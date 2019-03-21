using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsoleApp
{
    public class Ember
    {
        private static int emberCount = 0;
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value; 
            }
        }

        public Ember()
        {
            emberCount++;
        }

        public Ember (string name)
        {
            emberCount++;
            this.name = name;
        }

        public static int EmberCount
        {
            get
            {
                return emberCount;
            }
        }
    }
}
