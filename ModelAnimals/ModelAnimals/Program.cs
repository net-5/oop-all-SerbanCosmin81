using System;

namespace ModelAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            //mammal
            Platypus orni = new Platypus();
            orni.Swim();
            orni.Walk();
            orni.Name = "Platypus the new one";
            Console.WriteLine("My name is {0} and I can have a speed of {1} km/hour.\n", orni.Name, orni.GetSpeed());
            //fish
            FlyingFish fish = new FlyingFish();
            fish.Fly();
            fish.Swim();
            
            fish.Name = "FlyingFish the new one";
            Console.WriteLine("My name is {0} and I can have a speed of {1} km/hour.\n", fish.Name, fish.GetSpeed());
            //bird
            WildDuck duck = new WildDuck();
            duck.Swim();
            duck.Fly();
            duck.Walk();
            duck.Name = "WildDuck the new one";
            Console.WriteLine("My name is {0} and I can have a speed of {1} km/hour.\n", duck.Name, duck.GetSpeed());
            //reptile
            FlyingLizard lizard = new FlyingLizard();
            lizard.Fly();
            lizard.Crawl();
            lizard.Swim();
            lizard.Name = "FlyingLizard the new one";
            Console.WriteLine("My name is {0} and I can have a speed of {1} km/hour.\n", lizard.Name, lizard.GetSpeed());
            //insect
            Mosquito insect = new Mosquito();
            insect.Walk();
            insect.Fly();
            insect.Name = "BzzMosquitozzz";
            Console.WriteLine("My name is {0} and I can have a speed of {1} km/hour.\n", insect.Name, insect.GetSpeed());


        }
    }
}
