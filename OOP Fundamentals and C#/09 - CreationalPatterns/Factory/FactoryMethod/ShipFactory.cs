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
    }
}
