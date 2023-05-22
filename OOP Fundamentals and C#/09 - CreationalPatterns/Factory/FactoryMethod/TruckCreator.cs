namespace Factory.FactoryMethod
{
    public class TruckCreator : TransportCreator
    {
        public override ITransport CreateTransport(float capacity, string name)
        {
            var truck = new Truck
            {
                Capacity = capacity,
                Name = name
            };

            _counter++;

            return truck;
        }
    }
}
