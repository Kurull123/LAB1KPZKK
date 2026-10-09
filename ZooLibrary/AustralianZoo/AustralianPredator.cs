using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    internal class AustralianPredator : Predator
    {
        public AustralianPredator()
        {
            Name = "Saltwater crocodile";
            Species = "Crocodylus";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
