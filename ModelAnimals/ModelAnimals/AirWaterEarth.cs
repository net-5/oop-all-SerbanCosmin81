using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAnimals
{
    public abstract class AirWaterEarth : Mammal
    {
        private readonly new int wSpeed;

        public AirWaterEarth(string name, int wSpeed) : base(name, wSpeed)
        {
            this.wSpeed = wSpeed;
        }

        public abstract void AWEFlyWalkSwim();
        
       
    }
}
