using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// code added in github
namespace VizsgaraKeszules
{
    public class DefaultStuff
    {
        private int szam;
        public int Szam
        {
            get
            {
                return szam;
            }
            set
            {
                szam = value;
            }
        }
        private string szoveg;
        public string Szoveg
        {
            get
            {
                return szoveg;
            }
        }
        private bool igazHamis;
        public bool IgazHamis
        {
            get
            {
                return igazHamis;
            }
        }
        private DateTime idopont = DateTime.MinValue;
        public DateTime Idopont
        {
            get
            {
                return idopont;
            }
        }

    }
}
