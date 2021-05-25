using System;
// Thomas Zundel
// IT112 
// NOTES: In the shipper class on line 54 i made a really nice peice of code but unfortunatly i could not figure out how to use it on an array with null spaces
// BEHAVIORS NOT IMPLEMENTED AND WHY: I think I got everything 

namespace Zundel_Inventory
{
    class Program
    {

        static void Main(string[] args)
        {
            bool keepGoing = true;
            int choice;
            Shipper productList = new Shipper();
            while (keepGoing)
            {
                PrintMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write(productList.Add(new Bicycles()));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write(productList.Add(new LawnMowers()));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write(productList.Add(new BaseballGloves()));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write(productList.Add(new Crackers()));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write(productList.Print());
                        break;
                    case 6:
                        Console.Write(productList.ComputeShippingCost());
                        Console.WriteLine("\nPress any key to end the program");
                        Console.ReadKey();
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Option not supported");
                        break;
                }



                void PrintMenu()
                {
                    Console.WriteLine("Choose from the following options:");
                    Console.WriteLine("1. Add a Bicycle to the shipment");
                    Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                    Console.WriteLine("3. Add a Baseball Glove to the shipment");
                    Console.WriteLine("4. Add Crackers to the shipment");
                    Console.WriteLine("5. List Shipment Items");
                    Console.WriteLine("6. Compute Shipping Charges");

                }
            }
        }
    }
}
