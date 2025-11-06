using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Library
{
    public class CoffeeItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }

        public override string ToString() => $"{Name} ({Category}) - {Qty}";
    }
}
