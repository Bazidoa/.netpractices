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



        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0 && value <= 280)
                {
                    height = value;
                }
            }
        }

        private int weight;

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        private double bmiprop;

        public double Bmiprop
        {
            get
            {
                bmiprop = tomeg / (magassag * magassag);
                return bmiprop;
            }
        }

        //to do : alakítsd át read only propertyvé
        //public double GetBodyMassIndex()
        //{
        //    bmi = tomeg / (magassag * magassag);

        //    return bmi;
        //}

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
