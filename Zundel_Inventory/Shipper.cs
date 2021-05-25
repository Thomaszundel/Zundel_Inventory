using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_Inventory
{
    class Shipper
    {
        IShippable[] Inventory = new IShippable[10];
        int counter = 0;
        int bicycles = 0;
        int lawnMowers = 0;
        int crackers = 0;
        int baseballGloves = 0;
       
        public string Add(IShippable item)
        {

            Inventory[counter] = item;
            counter++;
            if(Inventory[counter-1].Product == "Crackers")
            {
                crackers++;
            }
            else if(Inventory[counter - 1].Product == "Bicycle")
            {
                bicycles++;
            }
            else if (Inventory[counter - 1].Product == "Lawn Mower")
            {
                lawnMowers++;
            }
            else
            {
                baseballGloves++;
            }

            return "1 "+Inventory[counter-1].Product + " has been added\nPress any key to return to the menu";
            

        }
        public string Print()
        {
            //for (int i = 0; i < 9; i++)
            //{
            //    if (Inventory[i] == null)
            //    {
            //        Inventory[i] = ??;
            //    }
            //}

            //int crackers = Inventory.Count(str => str.Product.Contains("Crackers"));
            string checkBicycles;
            string checkLawnMowers;
            string checkBaseballGloves;

           if (bicycles == 1)
            {
                checkBicycles = "Bicycle";
;            }
            else
            {
                checkBicycles = "Bicycles";
            }
           if(lawnMowers == 1)
            {
                checkLawnMowers = "Lawn Mower";
            }
            else
            {
                checkLawnMowers = "Lawn Mowers";
            }
            if(baseballGloves == 1)
            {
                checkBaseballGloves = "Baseball Glove";

            }
            else
            {
                checkBaseballGloves = "Baseball Gloves";
            }
           


            return "Shipment manifest:\n"+bicycles+" "+checkBicycles+"\n"+lawnMowers+" "+checkLawnMowers+"\n"+baseballGloves+" "+checkBaseballGloves+"\n"+crackers + " Crackers\n";
            
        }
        public string ComputeShippingCost()
        {
            decimal totalCost = 0;

            for (int i = 0; i < counter; i++)
            {
                totalCost += Inventory[i].ShipCost;
            }

            return "Total shipping cost for this order is " + Math.Round(totalCost, 2).ToString("C");
        }


    }
}
