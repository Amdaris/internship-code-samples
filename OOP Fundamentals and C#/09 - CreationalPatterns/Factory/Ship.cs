using System;

namespace Factory
{
    public class Ship : ITransporter
    {
        public string Name { get; set ; }
        public float Capacity { get; set; }

        public void Deliver()
        {
            Console.WriteLine("I deliver on sea");
        }
    }
}
