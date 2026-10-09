using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class AfricanBird : Bird
    {
        public AfricanBird()
        {
            Name = "Ostrich";
            Species = "Struthio";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
