using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public abstract class Bird
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Bird()
        {
            Name = "Unknown Bird";
            Species = "Unknown Species";
        }
       
        public abstract string GetInfo();
    }
}
