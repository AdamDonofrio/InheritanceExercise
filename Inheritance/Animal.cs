using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() { }
        public Animal(string name, string landSeaAir, int legCount, bool isAlive)
        {
            Name = name;
            LandSeaAir = landSeaAir;
            LegCount = legCount;
            IsAlive = isAlive;
        }

        //public getLegCount {};

        public string Name { get; set; } // get = read, set = write
        public string LandSeaAir { get; set; }

        public int LegCount { get; set; }

        public bool IsAlive { get; set; }

    }
}
