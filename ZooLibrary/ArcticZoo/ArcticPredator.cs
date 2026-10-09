using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class ArcticPredator : Predator
    {
        public ArcticPredator()
        {
            Name = "Polar bear";
            Species = "Ursus";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
