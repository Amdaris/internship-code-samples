using System;

namespace Factory.FactoryMethod
{
    public abstract class TransportCreator
    {
        public abstract Transport CreateTransport(float capacity, string name);

        public void DispatchTransport(float capacity)
        {
            Transport transport = CreateTransport(capacity, $"transporter-{Transport.Counter}");

            if (!transport.CheckDeliveryPermission())
            {
                Console.WriteLine($"Sorry, missing permission for transporter {transport.Name}");
                return;
            }

            transport.Deliver();

            var transportInfo = transport.GetTransportInformation();
            Console.WriteLine(transportInfo);
        }
    }
}
