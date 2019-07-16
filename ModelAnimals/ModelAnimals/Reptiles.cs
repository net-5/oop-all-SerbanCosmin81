using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public class Reptiles : Animal
    {
        public int CSpeed { get; set; }
        public Reptiles(string name, int cSpeed) : base(name)
        {
            CSpeed = cSpeed;
        }

        public void Crawl()

        {
            Console.WriteLine($"I'm a Reptile named {Name} and i can Crawl with {CSpeed}km/h");
        }
    }
}
