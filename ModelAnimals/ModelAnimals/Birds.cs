using System;
using System.Collections.Generic;
using System.Text;


namespace ModelAnimals
{
    public class Birds : AirWaterEarth
    {
        public  int WSpeed { get; set; }
        public int Fspeed { get; set; }

        public Birds(string name, int wSpeed, int fSpeed) : base(name,wSpeed)
        {
            WSpeed = wSpeed;
            Fspeed = fSpeed;
        }

        public override void AWEFlyWalkSwim()
        {
            if (Name=="WildDuck")
            {
                int sWSpeed = 36;
                Console.WriteLine($"i'm a {Name} and i can Fly with {Fspeed}Km/h , Walk with {WSpeed}Km/h and Swim {sWSpeed}km/h ");
            }
            else if (Name == "Ostrich")
            {
                Console.WriteLine($"i'm a {Name} and i can not FLY, I only Walk with {WSpeed} Km/h or Run verry fast with {Fspeed} Km/h");
            };
        }

        
        public void ClassFly()
        {
            Console.WriteLine($"I'm a Bird named {Name} and i can Fly with this speed {Fspeed} Km/h"); 
        }

        public void ClassWalk()
        {
            Console.WriteLine($"I'm a Bird named {Name} and i can Walk with this speed {WSpeed} Km/h");

        }
    }
}
