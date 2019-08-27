using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public abstract class Insect : Animal
    {
        public Insect()
        {
            Console.WriteLine("I'm an insect.");
        }
        public abstract int GetSpeed();
    }
}
