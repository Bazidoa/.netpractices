using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using KoszonesClassLibrary;

namespace KoszonesGUI
{
    class Program
    {
        private static Graf<Ember> talakozoraErkezettEmberekGrafja = new Graf<Ember>();
        private static GrafEl<Ember>[] mostLetrejottGrafElek = new GrafEl<Ember>[] { };
        public static void Main(string[] args)
        {
            #region Társaság
            Ember Pistike = new Ember("Pisti", new DateTime(2010, 3, 21), Gender.HimNemu);
            Ember ZsuzsaNeni = new Ember("Zsuzsa", new DateTime(1969, 9, 12), Gender.NoNemu);
            Ember Imi = new Ember("Imi", new DateTime(1970, 3, 21), Gender.HimNemu);
            Ember Peti = new Ember("Peti", new DateTime(2010, 3, 21), Gender.HimNemu);
            #endregion

            mostLetrejottGrafElek = talakozoraErkezettEmberekGrafja.AddPont(Pistike);
            PrintKoszonesekErkezeskor(Pistike, mostLetrejottGrafElek);

            mostLetrejottGrafElek = talakozoraErkezettEmberekGrafja.AddPont(ZsuzsaNeni);
            PrintKoszonesekErkezeskor(ZsuzsaNeni, mostLetrejottGrafElek);

            mostLetrejottGrafElek = talakozoraErkezettEmberekGrafja.AddPont(Imi);
            PrintKoszonesekErkezeskor(Imi, mostLetrejottGrafElek);

            mostLetrejottGrafElek = talakozoraErkezettEmberekGrafja.AddPont(Peti);
            PrintKoszonesekErkezeskor(Peti, mostLetrejottGrafElek);

            //Console.WriteLine($"Megérkezett {Pistike.Neve}");
            //Console.WriteLine(" ");
            //Console.WriteLine($"Megérkezett {ZsuzsaNeni.Neve}");
            //Console.WriteLine(TalalkozoEmberek.KoszonnekEgymasnak(ZsuzsaNeni, Pistike, new DateTime(2019,03,25)));
            //Console.WriteLine(" ");

            //Console.WriteLine($"Megérkezett {Imi.Neve}");
            //Console.WriteLine(TalalkozoEmberek.KoszonnekEgymasnak(Imi, ZsuzsaNeni, new DateTime(2019, 03, 25)));
            //Console.WriteLine(TalalkozoEmberek.KoszonnekEgymasnak(Imi, Pistike, new DateTime(2019, 03, 25)));
            //Console.WriteLine(" ");

            //Console.WriteLine($"Megérkezett {Peti.Neve}");
            //Console.WriteLine(TalalkozoEmberek.KoszonnekEgymasnak(Peti, ZsuzsaNeni, new DateTime(2019, 03, 25)));
            //Console.WriteLine(TalalkozoEmberek.KoszonnekEgymasnak(Peti, Pistike, new DateTime(2019, 03, 25)));
            //Console.WriteLine(TalalkozoEmberek.KoszonnekEgymasnak(Peti, Imi, new DateTime(2019, 03, 25)));


            Console.ReadKey();
        }
        private static void PrintKoszonesekErkezeskor(Ember megerkezett, GrafEl<Ember>[] grafElek)
        {

            Console.WriteLine("Megérkezett: " + megerkezett.Neve);
            for (int i = 0; i < grafElek.Length; i++)
            {
                Console.WriteLine($"     {TalalkozoEmberek.KoszonnekEgymasnak(grafElek[i].EgyikVegpont, grafElek[i].MasikVegpont, DateTime.Today)}");
            }
        }
    }
}
