using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_vs_Object
{
    public class BodyMass
    {
        private double tomeg;
        private double magassag;
        private double bmi;

        //public double BMI { get; private set; }

        public double GetBodyMassIndex()
        {
            bmi =tomeg / (magassag * magassag);

            return bmi;
        }

        public string GetBodyCategory()
        {
            string testalak = "Normal";

            if (bmi < 18.5)
            {
                testalak = "UnderWeight";
            }
            else if (bmi > 25)
            {
                testalak = "OverWeight";
            }
            return testalak;

        }
        public bool IsThinnerThan(BodyMass test)
        {
            bool result = false;
            if (this.bmi < test.bmi)
            {
                result = true;
            }
            return result;
           
        }
        public BodyMass(double tomeg, double magassag)
        {
            this.tomeg = tomeg;
            this.magassag = magassag;
        }
    }
}
