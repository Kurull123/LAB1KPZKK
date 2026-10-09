using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class AustralianZooFactory : AbstractZooFactory
    {
        public Predator createPredator()
        {
            return new AustralianPredator();
        }

        public Herbivore createHerbivore()
        {
            return new AustralianHerbivore();
        }

        public Bird createBird()
        {
            return new AustralianBird();
        }
    }
}
