namespace Factory.FactoryMethod
{
    public abstract class Transport
    {
        public string Name { get; set; }
        public float Capacity { get; set; }

        public static int Counter { get; private set; }

        public Transport()
        {
            Counter++;
        }

        public abstract bool CheckDeliveryPermission();
        public abstract void Deliver();
        public abstract string GetTransportInformation();
    }
}
