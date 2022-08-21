namespace Factory
{
    public class TruckFactory : ITransporterFactory
    {
        public ITransporter CreateTransporter(float capacity, string name)
        {
            return new Truck
            {
                Capacity = capacity,
                Name = name
            };
        }
    }
}
