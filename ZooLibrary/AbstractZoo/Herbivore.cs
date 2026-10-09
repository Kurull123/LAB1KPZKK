using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public abstract class Herbivore
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Herbivore()
        {
            Name = "Unknown Herbivore";
            Species = "Unknown Species";
        }
        public abstract string GetInfo();
    }
}
