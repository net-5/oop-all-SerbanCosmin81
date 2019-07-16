using System;

namespace ModelAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Insects myIns = new Insects("TigerFly",5,45);
            myIns.Walk();
            myIns.ClassFly();

            Mammal myMamm = new Mammal("Platypus",10);
            myMamm.Walk();
            Mammal myMamm2 = new Mammal("Bat", 35);
            myMamm2.Walk();
            

            Birds myBird1 = new Birds("Ostrich",8,60);
            myBird1.AWEFlyWalkSwim();

            AirWaterEarth myBird2 = new Birds("WildDuck",15,35);
            myBird2.AWEFlyWalkSwim();

            Reptiles myRep = new Reptiles("Snake",10);
            myRep.Crawl();
                
        }
    }
}
