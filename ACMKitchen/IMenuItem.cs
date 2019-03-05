using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMKitchen
{
    interface IMenuItem
    {
        int Price {get;}
        string Name { get; }
        void Consume(ref Customer customer);
    }
}
