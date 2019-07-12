using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotSauceReact.Models
{
    public class Sauce : ProductChild
    {
        public Spice SpicyLevel { get; set; }
        public enum Spice { mild, medium, hot};

    }
}
