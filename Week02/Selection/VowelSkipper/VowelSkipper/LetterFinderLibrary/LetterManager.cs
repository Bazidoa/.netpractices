using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFinderLibrary
{
    public class LetterManager
    {
        public char SkipIfVowel (char myChar)
        {
            char result = myChar;
            switch (myChar)
            {
                case 'a':
                    result ='b';
                    break;

                case 'e':
                    result ='f';
                    break;

                case 'i':
                    result ='j';
                    break;

                case 'o':
                    result ='p';
                    break;

                case 'u':
                    result ='v';
                    break;
            }
            return result;
        }
    }
}
