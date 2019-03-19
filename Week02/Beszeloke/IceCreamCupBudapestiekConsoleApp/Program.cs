using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalkingLollypopDebrecen;

namespace IceCreamCupBudapestiekConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember bala = new Ember();
            Console.WriteLine(bala.Beszelj());

            Kutya bacon = new Kutya();
            Console.WriteLine(bacon.Beszelj());

            Cica cirmi = new Cica();
            Console.WriteLine(cirmi.Beszelj());

            IBeszelokepes[] beszelokepesObjektumok = new IBeszelokepes[3];
            beszelokepesObjektumok[0] = bala;
            beszelokepesObjektumok[1] = bacon;
            beszelokepesObjektumok[2] = cirmi;

            for (int i = 0; i < beszelokepesObjektumok.Length; i++)
            {
                Console.WriteLine(beszelokepesObjektumok[i].Beszelj());
                // csak a leszármazottak közös metódusokat érem el.
            }
            Console.ReadKey();
        }
    }
}
