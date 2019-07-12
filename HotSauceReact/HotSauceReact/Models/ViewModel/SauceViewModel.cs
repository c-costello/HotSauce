using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models.ViewModel
{
    public class SauceViewModel
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public int PurchaseQuantity { get; set; }
        public Product.ProdType ProductType { get; set; }
        public Sauce.Spice SpicyLevel { get; set; }

    }
}
