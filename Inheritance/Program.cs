using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            var myBird = new Bird();
            myBird.Name = "Crow";
            myBird.BirdColor = "Red";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 4.9;

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var myReptile = new Reptile()
            {
                Name = "Lizard",
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true
            };

            var myAnimals = new Animal[] { myBird, myReptile };

            for (int i = 0; i < myAnimals.Length; i++)
            {
                //myAnimals[i]

                Console.WriteLine($"Name: {myAnimals[i].Name}");
                Console.WriteLine($"Alive: {myAnimals[i].IsAlive}");
                //Console.WriteLine($"Age: {myAnimals[i].Age}")
                Console.WriteLine($"It has {myAnimals[i].LegCount} legs");
                Console.WriteLine($"It lives by {myAnimals[i].LandSeaAir}");
                Console.WriteLine();
            }


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
