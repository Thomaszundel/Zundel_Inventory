using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_Inventory
{
    class LawnMowers : IShippable
    {
        private decimal _shipCost;
        private string _product;

        public LawnMowers()
        {
            _shipCost = 24.00m;
            _product = "Lawn Mower";
        }
        public decimal ShipCost
        {
            get { return _shipCost; }
        }

        public string Product
        {
            get { return _product; }
        }

    }
}
