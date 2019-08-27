using System;
using System.Collections.Generic;
using System.Text;


namespace ModelAnimals
{
    public abstract class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine("I'm a bird.");
        }
        public abstract int GetSpeed();

    }
}
