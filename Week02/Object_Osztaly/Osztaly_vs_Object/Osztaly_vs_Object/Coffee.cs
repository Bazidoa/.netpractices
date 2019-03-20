using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_vs_Object
{
    public class Coffee
    {
        public string Name { get; set; }
        private int strength;

        public int Strength
        {
            get { return strength; }
            set
            {
                if (value > 0 && value < 10)
                {
                    strength = value;
                }
            }
        }

        public string CountryOfOrigin { get; set; }


    }
}
