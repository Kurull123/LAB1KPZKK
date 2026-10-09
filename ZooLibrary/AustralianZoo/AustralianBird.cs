using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    internal class AustralianBird : Bird
    {
        public AustralianBird()
        {
            Name = "Swamphen";
            Species = "Rallidae";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
