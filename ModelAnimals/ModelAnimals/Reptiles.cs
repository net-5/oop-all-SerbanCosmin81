using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public abstract class Reptile : Animal
    {
        public Reptile()
        {
            Console.WriteLine("I'm a reptile.");
        }
        public abstract int GetSpeed();

    }
}
