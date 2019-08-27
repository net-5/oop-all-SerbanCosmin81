using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public abstract class Fish : Animal
    {
        public Fish()
        {
            Console.WriteLine("I'm a fish.");
        }
        public abstract int GetSpeed();
    }

}
