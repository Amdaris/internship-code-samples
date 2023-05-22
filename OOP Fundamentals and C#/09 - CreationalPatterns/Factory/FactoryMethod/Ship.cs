using System;
using System.Text;

namespace Factory.FactoryMethod
{
    public class Ship : Transport
    {
        public Ship() : base()
        {
        }

        public override bool CheckDeliveryPermission()
        {
            return this.Capacity > 25;
        }

        public override void Deliver()
        {
            Console.WriteLine("I deliver on sea.");
        }

        public override string GetTransportInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Ship: {this.Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");

            return sb.ToString();
        }
    }
}
