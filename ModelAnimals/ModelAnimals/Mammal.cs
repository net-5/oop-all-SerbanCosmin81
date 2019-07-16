using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Mammal : Animal
    {
        public int wSpeed { get; set; }
        public Mammal(string name, int wSpeed) : base(name)
        {
            this.wSpeed = wSpeed;
        }

        public virtual void Walk()
        {
            if (Name == "Platypus")
            {
                int sSpeed=25;
                Console.WriteLine($"I am a {Name} and i can walk with {wSpeed} Km/h  and swim {sSpeed}km/h");
            }
            else if (Name == "Bat")
            {
                int FSpeed = 35;

                Console.WriteLine($"I am a {Name} and i'm a Mammal and i can Fly {FSpeed}km/h");
            }
            else
            {
                Console.WriteLine($"I am a Mammal named {Name} and i can walk with {wSpeed}km/h");
            }
            

        }
    }
}
