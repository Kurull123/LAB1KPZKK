using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public abstract class Predator
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Predator()
        {
            Name = "Unknown Predator";
            Species = "Unknown Species";
        }
        public abstract string GetInfo();
    }
}
