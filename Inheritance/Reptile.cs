using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
        }

        public Reptile(bool isColdBlooded, bool isScaly, bool canGrowTail, string habitat) 
        { 
            IsColdBlooded = isColdBlooded;
            IsScaly = isScaly;
            CanGrowTail = canGrowTail;
            Habitat = habitat;
        }


        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public bool CanGrowTail { get; set; }

        public string Habitat { get; set; }
    }
}
