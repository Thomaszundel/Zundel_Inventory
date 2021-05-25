using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_Inventory
{
    class BaseballGloves : IShippable
    {
        private decimal _shipCost;
        private string _product;

        public BaseballGloves()
        {
            _shipCost = 3.23m;
            _product = "Baseball Glove";
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
