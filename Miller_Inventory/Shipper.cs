using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_Inventory
{
    class Shipper
    {
        // Variable-length list for cart items:
        private List<IShippable> cart = new List<IShippable>();

        //  Adds an item to the cart:
        public void Add(IShippable product)
        {
            cart.Add(product);
        }

        public decimal get_total_cost()
        {
            decimal total = 0;

            for ( int i = 0; i < cart.Count; ++i )
            {
                
                // Add the appropriate shipping cost to total:
                total += cart[i].ShipCost;
            }

            return total;
        }

        public int[] get_shipment_manifest()
        {
            int[] manifest = { 0, 0, 0, 0 };

            // Add to correct array entries based on type of goods:
            for ( int i = 0; i < cart.Count; ++i )
            {
                switch (cart[i].Product)
                {
                    case "Bicycle":
                        manifest[0] += 1;
                        break;
                    case "Lawn Mower":
                        manifest[1] += 1;
                        break;
                    case "Baseball Glove":
                        manifest[2] += 1;
                        break;
                    case "Crackers":
                        manifest[3] += 1;
                        break;
                }
            }

            return manifest;
        }
    }
}
