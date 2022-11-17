using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.SimpleFactory
{
    internal class PlanetFactory
    {
        public static IPlanet GetPlanet(string planetName) 
        {

            if (planetName.Equals("Mercury"))
                return new Mercury();
            else if (planetName.Equals("Venus"))
                return new Venus();
            else if (planetName.Equals("Mars"))
                return new Mars();
            else throw new ArgumentException($"Planet with name {planetName} does not exists");
        }


    }
}
