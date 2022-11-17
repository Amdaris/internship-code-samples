using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SimpleFactory
{
    internal class Venus : IPlanet
    {
        public string Name { get; set; } = "Venus";
        public double Radius { get; set; } = 6.051;
        public double Mass { get; set; } = 4867320;

        public double GetDistanceToEarth()
        {
            return 41400000;
        }
    }
}
