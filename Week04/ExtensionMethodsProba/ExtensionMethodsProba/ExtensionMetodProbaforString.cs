using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProba
{
    public class ExtensionMetodProbaforString
    {
        public string myText { get; set; }
        public char myChar { get; set; }

        public ExtensionMetodProbaforString(string text, char mychar)
        {
            this.myText = text;
            this.myChar = mychar;
        }
    }
}
