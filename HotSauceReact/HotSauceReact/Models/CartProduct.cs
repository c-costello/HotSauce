using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    public class CartProduct
    {
        public int CartID { get; set; }
        public int ProductTypeID { get; set; }
        public int Quantity { get; set; }
        public int TotalCost { get; set; }

    }
}
