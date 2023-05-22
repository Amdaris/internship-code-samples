using System;
using System.Text;

namespace Factory.FactoryMethod
{
    public class Truck : Transport
    {
        public Truck() : base()
        {
        }

        public override bool CheckDeliveryPermission()
        {
            return this.Capacity <= 25;
        }

        public override void Deliver()
        {
            Console.WriteLine("I deliver on land.");
        }

        public override string GetTransportInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Truck: {this.Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");

            return sb.ToString();
        }
    }
}
