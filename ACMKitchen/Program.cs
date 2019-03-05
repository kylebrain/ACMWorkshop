using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMKitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer me = new Customer();

            while(!me.Full && me.Money > 0)
            {
                Kitchen.Consume("Pasta", ref me);
                Kitchen.Consume("Garlic Bread", ref me);
                Kitchen.Consume("Water", ref me);
                Console.WriteLine("-----------");
            }

            
            Console.WriteLine(me);
        }
    }
}
