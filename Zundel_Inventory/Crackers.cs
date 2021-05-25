using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_Inventory
{
    class Crackers : IShippable
    {
        private decimal _shipCost;
        private string _product;

        public Crackers()
        {
            _shipCost = 0.57m;
            _product = "Crackers";
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
