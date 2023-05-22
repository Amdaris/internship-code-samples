namespace Factory.FactoryMethod
{
    public abstract class Transport
    {
        public string Name { get; set; }
        public float Capacity { get; set; }

        private static int _counter;
        public static int Counter { get { return _counter; } }

        public Transport()
        {
            _counter++;
        }

        public abstract bool CheckDeliveryPermission();
        public abstract void Deliver();
        public abstract string GetTransportInformation();
    }
}
