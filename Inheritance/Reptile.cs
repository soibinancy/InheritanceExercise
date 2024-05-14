using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public int ScaleCount { get; set; }
        public bool CanRegen { get; set; }
        public bool IsVenomous { get; set; }
        public bool CanSwim { get; set; }
        public string LandOrSea { get; set; }

    }
}
