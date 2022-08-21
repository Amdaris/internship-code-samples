namespace Factory
{
    public class ShipFactory : ITransporterFactory
    {
        public ITransporter CreateTransporter(float capacity, string name)
        {
            return new Ship
            {
                Capacity = capacity,
                Name = name
            };
        }
    }
}
