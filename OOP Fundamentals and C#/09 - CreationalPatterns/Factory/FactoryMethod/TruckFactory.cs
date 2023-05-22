using System;

namespace Factory.FactoryMethod
{
    public class TruckFactory : ITransportFactory
    {
        public ITransport CreateTransport(float capacity, string name)
        {
            return new Truck
            {
                Capacity = capacity,
                Name = name
            };
        }

        public void DispatchTransport(float capacity)
        {
            ITransport truck = CreateTransport(capacity, $"truck-{Guid.NewGuid()}");

            if (!truck.CheckDeliveryPermission())
            {
                Console.WriteLine($"Sorry, missing delivery permission for {truck.Name}\n");
                return;
            }

            truck.Deliver();

            var truckInfo = truck.GetTransportInformation();
            Console.WriteLine(truckInfo);
        }
    }
}
