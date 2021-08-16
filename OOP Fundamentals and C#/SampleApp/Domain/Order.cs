using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public override string ToString()
        {
            return string.Join("\n", OrderItems.Select(i => $"{i.Product.Name} x{i.Quantity}"));
        }
    }
}
