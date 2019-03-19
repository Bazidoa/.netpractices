using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_vs_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Client kliens = new Client();

            Console.WriteLine(kliens.Vezeteknev);
            kliens.Vezeteknev = "Bala";
            Console.WriteLine(kliens.Vezeteknev);

            kliens.Name = "Papa";
            Console.WriteLine(kliens.Name);

            kliens.Birthday = DateTime.Now;
            Console.WriteLine(kliens.Birthday);

            new Book();
            Console.WriteLine(new Book());

            Book emptyBook = null;
            Console.WriteLine(emptyBook);

            if (emptyBook == null)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }

            Book book = new Book();
            Console.WriteLine(book);
            book = null;
            Console.WriteLine(book);

            Book anotherBook = new Book();
            Console.WriteLine(book == anotherBook);

            anotherBook = book;
            Console.WriteLine(book == anotherBook);

            if (anotherBook is Book)
            {
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }

            Console.WriteLine(kliens.Address);
            kliens.Move("Budapest, Jégverem utca 8.");
            Console.WriteLine(kliens.Address);
            Console.ReadKey();

            BodyMass myBody = new BodyMass(70,1.78);
            BodyMass imiBody = new BodyMass(80, 1.72);
            imiBody.GetBodyMassIndex();

            Console.WriteLine(  myBody.GetBodyMassIndex());
            Console.WriteLine( myBody.GetBodyCategory());
            Console.WriteLine(myBody.IsThinnerThan(imiBody));

            Console.ReadKey(); 
        }
    }
}
