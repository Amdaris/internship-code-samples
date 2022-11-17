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
    }
}
