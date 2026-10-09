using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    internal class AustralianHerbivore : Herbivore
    {
        public AustralianHerbivore()
        {
            Name = "Kangaroo";
            Species = "Macropodinae";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}