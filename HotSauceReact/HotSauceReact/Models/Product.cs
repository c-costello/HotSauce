using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProdType ProductType { get; set; }
        public enum ProdType { TShirt, HotSauce}

    }
}
