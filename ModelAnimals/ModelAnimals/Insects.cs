using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Insects : Mammal
    {
        private readonly int fSpeed;

        public Insects(string name, int wSpeed, int fSpeed) : base(name,wSpeed)
        {
            this.wSpeed = wSpeed;
            this.fSpeed = fSpeed;
        }

        public void ClassFly()
        {
            Console.WriteLine($"i am an insect named {Name} and i can fly with {fSpeed}km/h");
        }

        public override void Walk()
        {
            Console.WriteLine($"I'm an insect named {Name} and i can walk with {wSpeed}Km/h"); ;
        }
    }
}
