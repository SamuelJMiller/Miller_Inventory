﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Inventory
{
    class Bicycle : IShippable
    {
        public decimal ShipCost { get; }
        public string Product { get; }

        public Bicycle()
        {
            this.ShipCost = 9.5M;
            this.Product = "Bicycle";
        }
    }
}
