using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    abstract public class ProductChild
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public string SKU { get; set; }
        public int InventoryQuantity { get; set; }

    }
}
