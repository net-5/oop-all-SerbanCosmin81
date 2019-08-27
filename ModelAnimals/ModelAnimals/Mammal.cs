using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public abstract class Mammal : Animal
    {
        public Mammal()
        {
            Console.WriteLine("I'm a mammal.");
        }
        public abstract int GetSpeed();
    }

    
}
