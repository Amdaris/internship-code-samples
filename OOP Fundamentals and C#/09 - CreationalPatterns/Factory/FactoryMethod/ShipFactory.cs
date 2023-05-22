using System;

namespace Factory.FactoryMethod
{
    public class ShipFactory : ITransportFactory
    {
        public ITransport CreateTransport(float capacity, string name)
        {
            return new Ship
            {
                Capacity = capacity,
                Name = name
            };
        }

        public void DispatchTransport(float capacity)
        {
            ITransport ship = CreateTransport(capacity, $"ship-{Guid.NewGuid()}");

            if (!ship.CheckDeliveryPermission())
            {
                Console.WriteLine("Sorry, missing delivery permission");
                return;
            }

            ship.Deliver();

            var shipInfo = ship.GetTransportInformation();
            Console.WriteLine(shipInfo);
        }
    }
}
