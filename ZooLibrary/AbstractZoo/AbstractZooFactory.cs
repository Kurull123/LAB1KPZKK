using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public interface AbstractZooFactory
    {
        Predator createPredator();
        Herbivore createHerbivore();
        Bird createBird();
    }
}
