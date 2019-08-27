using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class WildDuck : Bird, ISwim, IWalk, IFly
    {
        public void Swim()
        {
            Console.WriteLine("I'm a Wild Duck and I can swim.");
        }

        public void Walk()
        {
            Console.WriteLine("I'm a Wild Duck and I can walk.");
        }

        public void Fly()
        {
            Console.WriteLine("I'm a Wild Duck and I can fly.");
        }

        public override int GetSpeed()
        {
            return 50;
        }

    }
}
