using System;

namespace Factory.FactoryMethod
{
    public class Ship : ITransport
    {
        public string Name { get; set; }
        public float Capacity { get; set; }

        public void Deliver()
        {
            Console.WriteLine("I deliver on sea");
        }
    }
}
