using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProba
{
    public static class MyExtension
    {
        public static int CharCounter(this string text, char myChar)
        {
            int counter = 0;

            foreach (var character in text)
            {
                if (character == myChar)
                {
                    counter++;
                }
                
            }
            return counter;
        }
    }
}
