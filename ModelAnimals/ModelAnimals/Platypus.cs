using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Platypus : Mammal, ISwim, IWalk
    {
        public void Swim()
        {
            Console.WriteLine("I'm a Platypus and I can swim.");
        }

        public void Walk()
        {
            Console.WriteLine("I'm a Platypus and I can walk.");
        }
        public override int GetSpeed()
        {
            return 35;
        }

    }
}
