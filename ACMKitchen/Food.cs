using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMKitchen
{
    class Food : MenuItem
    {
        int hungerPoints;
        int stock;

        protected Food(int _stock, int _hungerPoints, string _name, int _price) : base(_name, _price)
        {
            stock = _stock;
            hungerPoints = _hungerPoints;
        }

        public override void Consume(ref Customer customer)
        {
            if(stock > 0)
            {
                customer.HungerLevel -= hungerPoints;
                stock--;
                customer.Money -= price;
                Console.WriteLine("Ate " + name);
            } else
            {
                Console.WriteLine("We're out of " + name);
            }
        }
    }
}
