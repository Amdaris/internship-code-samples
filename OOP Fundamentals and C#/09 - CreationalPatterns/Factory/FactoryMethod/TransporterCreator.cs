namespace Factory.FactoryMethod
{
    internal class TransporterCreator : TransportCreator
    {
        public override ITransport CreateTransport(float capacity, string name)
        {
            ITransport transport;

            if (capacity > 25)
            {
                transport = new Ship
                {
                    Capacity = capacity,
                    Name = name
                };
            }
            else
            {
                transport = new Truck
                {
                    Capacity = capacity,
                    Name = name
                };
            }

            _counter++;

            return transport;
        }
    }
}
