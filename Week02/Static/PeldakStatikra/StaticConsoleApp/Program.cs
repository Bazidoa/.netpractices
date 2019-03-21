using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsoleApp
{
    class Program
    {
        private static string s = "Hello World";


        static void Main(string[] args)
        {
            Console.WriteLine(s);
            //staticus methóduson belül csak statikus tagváltozót agy függvényt lehet elérni

            Console.WriteLine(Helloka("Feri"));

            Console.WriteLine(Ember.EmberCount);

            Ember elsoEmber = new Ember("Rafi");
            Console.WriteLine(Ember.EmberCount);

            Ember masodikEmber = new Ember("Bob");
            Console.WriteLine(Ember.EmberCount);
            Ember harmadikEmber = new Ember("Dzson");
            Console.WriteLine(Ember.EmberCount);
            Ember negyedikEmber = new Ember("Rex");
            Console.WriteLine(Ember.EmberCount);
            Ember otodikEmber = new Ember("Jason");
            Console.WriteLine(Ember.EmberCount);

            Console.WriteLine(harmadikEmber.Name);
            harmadikEmber.Name = "Ms. Rex";

            Console.WriteLine(harmadikEmber.Name);
            Console.ReadKey();

        }

        private static string Helloka(string name)
        {

            return "Szia " + name;
        }
    }
}
