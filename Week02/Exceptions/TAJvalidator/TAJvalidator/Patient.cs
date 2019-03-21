using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TAJvalidator
{
    class Patient
    {
        private string Name;
        private string socialSecurityNumber;
        //\d[0-9]{9}
        public string SocialSecurityNumber
        {
            set
            {
                string tajregex = @"^\d{9}$"; // \d == [0-9]
                bool result = Regex.IsMatch(value,tajregex);
                if (result == true)
                {
                    socialSecurityNumber = value;
                } else
                {
                    throw new ArgumentException($"Adj meg valós TAJ-t.");
                }
                 
            }
        }



        private int yearOfBirth;
        public int YearOfBirth
        {
            set
            {
                if (value < 1900)
                {
                    throw new ArgumentOutOfRangeException("You can't be that old.");
                }
                else
                {
                    yearOfBirth = value;
                }
            }
        }


    }
}
