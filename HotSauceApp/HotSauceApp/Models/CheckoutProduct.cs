using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models
{
    public class CheckoutProduct
    {
        public int CheckoutID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        //Navigational Properties
        public Product Product { get; set; }
        public Checkout Checkout { get; set; }
    }
}
