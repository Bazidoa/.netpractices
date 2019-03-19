using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkingLollypopDebrecen
{
    public class Cica : IBeszelokepes
    {
        public string Beszelj()
        {
            string result = String.Empty; // a kettős idézőjel megvalósítástól függően lehet, hogy nem lesz üres string

            result = "miau miau boiiii";

            return result;
        }
    }
}
