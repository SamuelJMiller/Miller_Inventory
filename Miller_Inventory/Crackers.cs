using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Inventory
{
    class Crackers : IShippable
    {
        public decimal ShipCost { get; }
        public string Product { get; }

        public Crackers()
        {
            this.ShipCost = 0.57M;
            this.Product = "Crackers";
        }
    }
}
