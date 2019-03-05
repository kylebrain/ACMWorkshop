using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMKitchen
{
    class Customer
    {
        public int ThirstLevel = 100;
        public int HungerLevel = 100;

        public int Money = 100;

        public bool Full
        {
            get
            {
                return ThirstLevel <= 0 && HungerLevel <= 0;
            }
        }

        public override string ToString()
        {
            string ret = ThirstLevel + "% thirst, " + HungerLevel + "% hunger.\n";
            ret += Full ? "Full!" : "Still not full!";
            ret += "\n$" + Money + " Left!";

            return ret;
        }
    }
}
