using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceApp.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public string UserID { get; set; }

        public int Total { get; set; }

        //Navigational Properties
        public IEnumerable<CartProduct> CardProducts { get; set; }

    }
}
