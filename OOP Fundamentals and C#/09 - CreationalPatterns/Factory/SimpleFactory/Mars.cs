using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SimpleFactory
{
    internal class Mars : IPlanet
    {
        public string Name { get; set; } = "Mars";
        public double Radius { get; set; } = 3.389;
        public double Mass { get; set; } = 641693000;

        public double GetDistanceToEarth()
        {
            return 78340000;
        }
    }
}
