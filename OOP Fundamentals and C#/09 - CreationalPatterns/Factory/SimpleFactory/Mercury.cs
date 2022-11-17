using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SimpleFactory
{
    internal class Mercury : IPlanet
    {
        public string Name { get; set; } = "Mercury";
        public double Radius { get; set; } = 2.439;
        public double Mass { get; set; } = 330104000;

        public double GetDistanceToEarth()
        {
            return 91691000;
        }
    }
}
