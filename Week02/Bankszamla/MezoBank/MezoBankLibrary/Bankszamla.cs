using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezoBankLibrary
{
    public class Bankszamla
    {
        private string tulajNev;
        
        private int szamlaszam;
        public int Szamlaszam //5 számjegyű számnak kell lennie
        {
            get
            {
                return szamlaszam;
            }
            set
            {
                if (value>9999 && value < 100000 )
                {
                szamlaszam = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Nem 5 jegyű számot adtál meg");
                }
            }
        }

        private int egyenleg;

        public Bankszamla(string tulajNev)
        {
            this.tulajNev = tulajNev;
            this.egyenleg = 0;
            this.szamlaszam = -99;
        }

        public int EgyenlegNovel (int betettOsszeg)
        {
            NemLehetNegativValidalo(betettOsszeg);
            this.egyenleg += betettOsszeg;
            return this.egyenleg;
        }

        public int EgyenlegCsokkent (int kivettOsszeg)
        {
            NemLehetNegativValidalo(kivettOsszeg);
            this.egyenleg -= kivettOsszeg;
            return this.egyenleg;
        }

        public void NemLehetNegativValidalo(int beutottOsszeg)
        {
            if (beutottOsszeg < 0)
            {
                throw new ArgumentOutOfRangeException("Nem lehet negatív a beütött összeg.");
            }
        }
    }
}

