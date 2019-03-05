using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMKitchen
{
    static class Kitchen
    {
        public static List<IMenuItem> Menu= new List<IMenuItem>();

        static Kitchen()
        {
            Menu.Add(new Pasta(2));
            Menu.Add(new GarlicBread(10));
            Menu.Add(new Water());
        }

        public static void Consume(string name, ref Customer customer)
        {
            IMenuItem item = Menu.Find(x => x.Name == name);

            if(item != null)
            {
                item.Consume(ref customer);
            }
        }
    }
}
