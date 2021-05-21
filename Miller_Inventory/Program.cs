using System;

// Samuel Miller
// IT112 

namespace Miller_Inventory
{
    class Program
    {
        static void show_menu()
        {
            Console.WriteLine("Choose from the following options:" +
                "\n1. Add a Bicycle to the shipment" +
                "\n2. Add a Lawn Mower to the Shipment" +
                "\n3. Add a Baseball Glove to the shipment" +
                "\n4. Add Crackers to the shipment" +
                "\n5. List Shipment Items" +
                "\n6. Compute Shipping Charges");
        }

        static void cart_confirmation(string product)
        {
            Console.WriteLine("1 " + product + " has been added" +
                "\nPress any key to return to the menu");
            Console.ReadLine();
        }

        static void display_manifest_item(string product, int count)
        {
            if (count == 1)
                Console.WriteLine(" " + product);
            else
                Console.WriteLine(" " + product + "s");
        }

        static void Main(string[] args)
        {
            // Shopping cart:
            Shipper cart = new Shipper();

            while (true)
            {
                // Show menu for first time:
                show_menu();

                // Get number choice with assumption that data will be acceptable:
                int user_choice = Int32.Parse(Console.ReadLine());

                switch (user_choice)
                {
                    case 1:
                        cart.Add(new Bicycle());
                        cart_confirmation("Bicycle");
                        break;
                    case 2:
                        cart.Add(new LawnMower());
                        cart_confirmation("Lawn Mower");
                        break;
                    case 3:
                        cart.Add(new BaseballGlove());
                        cart_confirmation("Baseball Glove");
                        break;
                    case 4:
                        cart.Add(new Crackers());
                        cart_confirmation("Crackers");
                        break;
                    case 5:
                        int[] manifest = cart.get_shipment_manifest();

                        Console.Write("Shipment manifest:" +
                            "\n" + manifest[0] + " ");
                        display_manifest_item("Bicycle", manifest[0]);

                        Console.Write(manifest[1] + " ");
                        display_manifest_item("Lawn Mower", manifest[1]);

                        Console.Write(manifest[2] + " ");
                        display_manifest_item("Baseball Glove", manifest[2]);

                        Console.Write(manifest[3] + " ");
                        Console.WriteLine("Crackers");

                        Console.WriteLine("Press any key to continue");
                        Console.Read();

                        break;
                    case 6:
                        // Show message and exit program:
                        Console.WriteLine("Total shipping cost for this order is $" + cart.get_total_cost());
                        return;
                }
            }
        }
    }
}
