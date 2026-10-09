using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class ArcticHerbivore : Herbivore
    {
        public ArcticHerbivore()
        {
            Name = "Lemming";
            Species = "Arvicolinae";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
