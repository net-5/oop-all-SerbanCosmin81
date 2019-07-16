using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Fish : Mammal
    {
        private static readonly int sWSpeed;

        public Fish(string name) : base(name, sWSpeed)
        {
            this.wSpeed = sWSpeed;
        }

        public void Swim()
        {
            Console.WriteLine($"I'm a fish named {Name} and my Native Meth is swimming with this speed {sWSpeed}km/h"); 
        }
    }
}
