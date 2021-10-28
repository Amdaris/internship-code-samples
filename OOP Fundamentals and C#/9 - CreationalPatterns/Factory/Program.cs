namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransporter ship = shipFactory.CreateTransporter(name: "Ship1",capacity:2500);
            ITransporter truck = truckFactory.CreateTransporter(name: "Truck1",capacity:25);

            ship.Deliver();
            truck.Deliver();
        }
    }
}
