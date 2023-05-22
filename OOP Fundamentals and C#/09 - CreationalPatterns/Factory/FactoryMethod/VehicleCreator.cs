namespace Factory.FactoryMethod
{
    internal class VehicleCreator : TransportCreator
    {
        public override Transport CreateTransport(float capacity, string name)
        {
            if (capacity > 25)
            {
                return new Ship
                {
                    Capacity = capacity,
                    Name = name
                };
            }
            else
            {
                return new Truck
                {
                    Capacity = capacity,
                    Name = name
                };
            }
        }
    }
}
