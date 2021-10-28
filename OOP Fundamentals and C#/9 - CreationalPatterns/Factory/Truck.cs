using System;

namespace Factory
{
    public class Truck : ITransporter
    {
        public string Name { get; set; }
        public float Capacity { get; set; }

        public void Deliver()
        {
            Console.WriteLine("I deliver on land.");
        }
    }
}
