using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.FactoryMethod
{
    internal class TransporterFactory : ITransportFactory
    {
        public ITransport CreateTransport(float capacity, string name)
        {
            if (capacity > 25)
                return new Ship
                {
                    Capacity = capacity,
                    Name = name
                };
            else
                return new Truck
                {
                    Capacity = capacity,
                    Name = name
                };
        }
    }
}
