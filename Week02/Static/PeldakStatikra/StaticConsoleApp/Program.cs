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

            Ember elsoEmber = new Ember();
            Console.WriteLine(Ember.EmberCount);

            Ember masodikEmber = new Ember();
            Console.WriteLine(Ember.EmberCount);
            Ember harmadikEmber = new Ember();
            Console.WriteLine(Ember.EmberCount);
            Ember negyedikEmber = new Ember();
            Console.WriteLine(Ember.EmberCount);
            Ember otodikEmber = new Ember();
            Console.WriteLine(Ember.EmberCount);


            Console.ReadKey();

        }

        private static string Helloka(string name)
        {

            return "Szia " + name;
        }
    }
}
