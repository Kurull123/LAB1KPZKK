using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class AfricanPredator : Predator
    {
        public AfricanPredator()
        {
            Name = "Lion";
            Species = "Panthera leo";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
