using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_Inventory
{
    class Bicycles : IShippable
    {
        private decimal _shipCost;
        private string _product;

        public Bicycles()
        {
            _shipCost = 9.50m;
            _product = "Bicycle";
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
