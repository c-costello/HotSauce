using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    abstract public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public object Size { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }

    }
}
