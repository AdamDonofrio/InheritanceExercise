using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        { 
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";

        }

        /*public Bird(string birdColor, bool canFly, bool willMigrate, double beakLength) 
        {
            BirdColor = birdColor;
            CanFly = canFly;
            WillMigrate = willMigrate;
            BeakLength = beakLength;
        }
        */
        public string BirdColor { get; set; }
        public bool CanFly { get; set;}
        public bool WillMigrate { get; set;}

        public double BeakLength { get; set;}
    }
}
