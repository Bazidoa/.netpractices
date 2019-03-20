using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_vs_Object
{
   public class Pendrive
    {
        private string name;
        private int capacity;
        private int price;
        public int Price {
            get { return price; }
        }

        //returns the data of the pendrive as String
        public override string ToString()
        {
            StringBuilder myStringbuilder = new StringBuilder(name);
            myStringbuilder.Append(" ");
            myStringbuilder.Append(capacity);
            myStringbuilder.Append("GB");
            myStringbuilder.Append(" ");
            myStringbuilder.Append(price);
            myStringbuilder.Append("Ft");

            string dataOfPendrive = myStringbuilder.ToString();
            return dataOfPendrive;
        }

        //increases the pendrives price by given percent
        public void IncreasePrice (int percent)
        {

            price = price + (price * (percent / 100));
            Console.WriteLine($"The price has been increased by " + percent + "%.");

        }

        //compare two pendrives by price / capacity
        public int ComparePricePerCapacity(Pendrive secondPendrive)
        {
            int result = 0;
            if (this.price/this.capacity > secondPendrive.price / secondPendrive.capacity)
            {
                result = 1;
            }
            if (this.price / this.capacity < secondPendrive.price / secondPendrive.capacity)
            {
                result = -1;
            }
            return result;
        }

        //compares called and given pendrives prices, returns true false
        public bool IsCheaperThan(Pendrive secondPendrive)
        {
            bool result = false;
            if (this.price < secondPendrive.price)
            {
                result = true;
            }
            return result;
        }

        //construtor
        public Pendrive (string name, int capacity, int price)
        {
            this.name = name;
            this.capacity = capacity;
            this.price = price;
        }
    }
}
