using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class FlyingLizard : Reptile, ISwim, ICrawl, IFly
    {
        public void Swim()
        {
            Console.WriteLine("I'm a Flying Lizard and I can swim.");
        }

        public void Crawl()
        {
            Console.WriteLine("I'm a Flying Lizard and I can crawl.");
        }

        public void Fly()
        {
            Console.WriteLine("I'm a Flying Lizard and I can fly on small distances.");
        }
        public override int GetSpeed()
        {
            return 30;
        }

    }
}
