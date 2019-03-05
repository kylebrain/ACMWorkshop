using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMKitchen
{
    class Drink : MenuItem
    {
        int thirstPoints;
        bool purchased = false;

        protected Drink(int _thirstPoints, string _name, int _price) : base(_name, _price)
        {
            thirstPoints = _thirstPoints;
        }

        public override void Consume(ref Customer customer)
        {
            if(!purchased)
            {
                purchased = true;
                customer.Money -= price;
            }

            Console.WriteLine("Drank " + name);

            customer.ThirstLevel -= thirstPoints;
        }

    }
}
