using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMKitchen
{
    abstract class MenuItem : IMenuItem
    {
        protected int price;
        protected string name;

        public int Price
        {
            get
            {
                return price;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public MenuItem(string _name, int _price)
        {
            name = _name;
            price = _price;
        }

        abstract public void Consume(ref Customer customer);
    }
}
