using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isNocturnal { get; set; }
        public string Diet {  get; set; }
        public int LegCount { get; set; }
    }
}
