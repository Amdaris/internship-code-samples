using System;
using System.Text;

namespace Factory.FactoryMethod
{
    public class Ship : ITransport
    {
        public string Name { get; set; }
        public float Capacity { get; set; }

        public bool CheckDeliveryPermission()
        {
            return this.Capacity > 25;
        }

        public void Deliver()
        {
            Console.WriteLine("I deliver on sea.");
        }

        public string GetTransportInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Ship: {this.Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");

            return sb.ToString();
        }
    }
}
