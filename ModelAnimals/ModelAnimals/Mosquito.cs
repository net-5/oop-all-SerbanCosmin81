using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Mosquito : Insect, IWalk, IFly
    {
        public void Walk()
        {
            Console.WriteLine("I'm a Mosquito and I can walk.");
        }

        public void Fly()
        {
            Console.WriteLine("I'm a Mosquito and I can fly.");
        }
        public override int GetSpeed()
        {
            return 15;
        }
    }
}
