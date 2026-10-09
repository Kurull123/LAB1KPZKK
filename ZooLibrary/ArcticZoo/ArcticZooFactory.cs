using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class ArcticZooFactory : AbstractZooFactory
    {
        public Predator createPredator()
        {
            return new ArcticPredator();
        }

        public Herbivore createHerbivore()
        {
            return new ArcticHerbivore();
        }

        public Bird createBird()
        {
            return new ArcticBird();
        }
    }
}
