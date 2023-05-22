using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void DispatchTransport(float capacity)
        {
            ITransport transport = CreateTransport(capacity, $"transporter-{Guid.NewGuid()}");

            transport.Deliver();

            var transportInfo = transport.GetTransportInformation();
            Console.WriteLine(transportInfo);
        }
    }
}
