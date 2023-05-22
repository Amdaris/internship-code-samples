using System;

namespace Factory.FactoryMethod
{
    public abstract class TransportCreator
    {
        protected static int _counter;

        public abstract ITransport CreateTransport(float capacity, string name);

        public void DispatchTransport(float capacity)
        {
            ITransport transport = CreateTransport(capacity, $"transporter-{_counter}");

            if (!transport.CheckDeliveryPermission())
            {
                Console.WriteLine($"Sorry, missing permission for transporter {transport.Name}\n");
                return;
            }

            transport.Deliver();

            var transportInfo = transport.GetTransportInformation();
            Console.WriteLine(transportInfo);
        }
    }
}
