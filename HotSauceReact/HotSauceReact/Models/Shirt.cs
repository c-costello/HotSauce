using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    public class Shirt : ProductChild 
    {
        public ColorType Color { get; set; }
        public enum ColorType { Black, White, Green, Red}  
    }
}
