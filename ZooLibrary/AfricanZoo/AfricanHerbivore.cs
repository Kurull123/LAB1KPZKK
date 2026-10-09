using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class AfricanHerbivore : Herbivore
    {
        public AfricanHerbivore()
        {
            Name = "Hyrax";
            Species = "Procaviidae";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
