using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class FlyingFish : Fish, ISwim, IFly
    {
        public void Swim()
        {
            Console.WriteLine("I'm a Flying Fish and I can swim.");
        }

        public void Fly()
        {
            Console.WriteLine("I'm a Flying Fish and I can fly a little.");
        }
        public override int GetSpeed()
        {
            return 25;
        }

    }
}
