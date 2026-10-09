using System;
using System.Collections.Generic;
using System.Text;

namespace ZooLibrary
{
    public class ArcticBird : Bird
    {
        public ArcticBird()
        {
            Name = "Penguin";
            Species = "Spheniscidae";
        }
        public override string GetInfo()
        {
            return $"Name: {Name}, Species: {Species}";
        }
    }
}
