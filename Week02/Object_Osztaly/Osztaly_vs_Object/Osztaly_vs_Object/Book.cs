using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_vs_Object
{
    class Book
    {
        private string Author;
        private string Title;
        private string RegNumber;

        public void Register(string regNumber)
        {
            RegNumber = regNumber;
        }

    }
}
