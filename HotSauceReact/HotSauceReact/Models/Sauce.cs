using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    public class Sauce : Product
    {
        public int ProductID { get; set; }
        public string SpicyLevel { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
    }
}
