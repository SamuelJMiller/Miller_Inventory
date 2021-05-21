using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Inventory
{
    class BaseballGlove : IShippable
    {
        public decimal ShipCost { get; }
        public string Product { get; }

        public BaseballGlove()
        {
            this.ShipCost = 3.23M;
            this.Product = "Baseball Glove";
        }
    }
}
