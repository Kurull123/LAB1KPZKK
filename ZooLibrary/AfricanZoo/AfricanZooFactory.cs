using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class AfricanZooFactory : AbstractZooFactory
    {
        public Predator createPredator()
        {
            return new AfricanPredator();
        }

        public Herbivore createHerbivore()
        {
            return new AfricanHerbivore();
        }

        public Bird createBird()
        {
            return new AfricanBird();
        }
    }
}
