using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLibrary;

namespace TalkingLollypopDebrecen
{
    public class Kutya : IBeszelokepes
    {
        public string Beszelj()
        {
            string result = String.Empty; // a kettős idézőjel megvalósítástól függően lehet, hogy nem lesz üres string

            result = "vau vau boiiii";

            return result;
        }
    }
}
