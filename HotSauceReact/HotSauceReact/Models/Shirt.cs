using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    public class Shirt 
    {
        public int ProductID { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public ColorType Color { get; set; }
        public enum ColorType { Black, White, Green, Red}  
    }
}
