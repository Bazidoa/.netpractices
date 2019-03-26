using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace KoszonesClassLibrary
{
    public class Ember
    {
        private string neve;
        public string Neve
        {
            get { return neve; }
            set { neve = value; }
        }


        private DateTime szuletesiDatuma;
        public DateTime SzuletesiDatuma
        {
            get { return szuletesiDatuma; }
        }


        private Gender neme;
        public Gender Neme
        {
            get { return neme; }
        }



        public Ember(string neve, DateTime szuletesiDatuma, Gender neme)
        {
            this.neve = neve;
            this.szuletesiDatuma = szuletesiDatuma;
            this.neme = neme;
        }

        public int HanyEvesEkkor(DateTime ekkor)
        {
            int result = 0;
            result = ekkor.Year - this.szuletesiDatuma.Year;
            return result;
        }
    }
}
