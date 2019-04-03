using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            //ARRAY LIST 


            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add(13);
            myArrayList.Add(11);
            myArrayList.Add(5);
            myArrayList.Add(9);

            for (int i = 0; i < myArrayList.Count; i++)
            {
            Console.WriteLine(myArrayList[i]);
            }
            Console.WriteLine( myArrayList.Capacity);

            myArrayList.Remove(11);
            Console.WriteLine(" ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.WriteLine(myArrayList.Capacity);

            myArrayList.Sort();
            Console.WriteLine(" ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            myArrayList.Insert(1, 100);
            Console.WriteLine(" ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            myArrayList.Add(100);

            Console.WriteLine(" ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            myArrayList.Remove(100);

            Console.WriteLine(" ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.WriteLine(  myArrayList.Contains(13));
            Console.WriteLine(" ");

            Console.WriteLine(myArrayList.IndexOf(200));
            Console.WriteLine(myArrayList.IndexOf(5));

            myArrayList.Clear();
            Console.WriteLine(" ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.WriteLine(myArrayList.Capacity  );

            // GENREIKUS LIST

            List<int> myList = new List<int>();
            myList.Add(55);
            // myList.Add("alma"); -- nem is engedi lefordítani az Intellisense mert hiba lenne piros aláhúzás

            List<string> myStringList = new List<string>();

            myStringList.Add("alma");
            myStringList.Add("körte");
            myStringList.Add("banán");

            Console.WriteLine("//LIST//");
            for (int i = 0; i < myStringList.Count; i++)
            {
                Console.WriteLine(myStringList[i]);
            }
            Console.WriteLine("//LIST to console with foreach//");

            foreach ( string item in myStringList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
