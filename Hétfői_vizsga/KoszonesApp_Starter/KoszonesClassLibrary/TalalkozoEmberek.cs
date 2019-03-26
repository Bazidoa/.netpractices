using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace KoszonesClassLibrary
{
    public class TalalkozoEmberek
    {
        public static string KoszonnekEgymasnak(Ember lho, Ember rho, DateTime ekkor)
        {
            string result="";
            EletkoriBesorolas lhoEletkoriBesorolas = CalculateEletkoriBesorolas(lho, ekkor);
            EletkoriBesorolas rhoEletkoriBesorolas = CalculateEletkoriBesorolas(rho, ekkor);

            string lhoNev =lho.Neve; 

            //azonos korúak taliznak
            if (lhoEletkoriBesorolas == rhoEletkoriBesorolas)
            {
                //Console.WriteLine($"Szia {rho.Neve} !");
                //Console.WriteLine($"Szia {lho.Neve} !");
                result = $"Szia {rho.Neve}! <--> Szia {lhoNev}!";
            }

            //kiskorú találkozik férfival
            else if (lhoEletkoriBesorolas == EletkoriBesorolas.Kiskoru && rho.Neme == Gender.HimNemu)
            {
                result = $"Jó napot {rho.Neve} bácsi! <--> Szervusz {lhoNev}!";
            }

            //kiskorú találkozik nővel
            else if (lhoEletkoriBesorolas == EletkoriBesorolas.Kiskoru && rho.Neme == Gender.NoNemu)
            {
                result = $"Csókolom {rho.Neve} néni! <--> Szervusz {lhoNev}!";
            }

            //férfi találkozik kiskorúval
            else if (rhoEletkoriBesorolas == EletkoriBesorolas.Kiskoru && lho.Neme == Gender.HimNemu)
            {
                result = $"Szervusz {rho.Neve}! <--> Jó napot {lhoNev} bácsi!";
            }

            //nő találkozik kiskorúval
            else if (rhoEletkoriBesorolas == EletkoriBesorolas.Kiskoru && lho.Neme == Gender.NoNemu)
            {
                result = $"Szervusz {rho.Neve}! <--> Csókolom {lhoNev} néni!";
            }
            return result;
        }

        private static EletkoriBesorolas CalculateEletkoriBesorolas(Ember szemely, DateTime ekkor)
        {
            EletkoriBesorolas myBesorolas = EletkoriBesorolas.Kiskoru;

            if (szemely.HanyEvesEkkor(ekkor) > 18)
            {
                myBesorolas = EletkoriBesorolas.Nagykoru;
            }
            return myBesorolas;
        }
    }
}
