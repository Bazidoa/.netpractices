using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yellowroad
{
    public class Client
    {
        public string Vezeteknev
        {
            get; set;
        } = "xy";

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }

        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private string address = "default location";
        public string Address 
        {
            get { return address; }
            set { address = value; }
        } 

        public void Move(string newAddress)
        {
            address = newAddress; 
            //this.address-is működik, anélkül szebb
        }

    }

    
}
