using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Order
    {
        // DDD Patterns comment
        // Using a private collection field, better for DDD Aggregate's encapsulation
        // so OrderItems cannot be added from "outside the AggregateRoot" directly to the collection,
        // but only through the method Order.AddOrderItem() which includes behavior.
        private readonly List<OrderItem> _orderItems = new();

        public Order(string buyerName, List<OrderItem> orderItems)
        {
            _orderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));
            BuyerName = buyerName ?? throw new ArgumentNullException(nameof(buyerName));
        }

        public int Id { get; set; }

        public string BuyerName { get; init; }

        // Using List<>.AsReadOnly() 
        // This will create a read only wrapper around the private list so is protected against "external updates".
        // It's much cheaper than .ToList() because it will not have to copy all items in a new collection. (Just one heap alloc for the wrapper instance)
        //https://msdn.microsoft.com/en-us/library/e78dcd75(v=vs.110).aspx 
        public IReadOnlyList<OrderItem> OrderItems => _orderItems.AsReadOnly();

        public void AddOrderItem(OrderItem orderItem)
        {
            _orderItems.Add(orderItem ?? throw new ArgumentNullException(nameof(orderItem)));
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            _orderItems.Remove(orderItem ?? throw new ArgumentNullException(nameof(orderItem)));
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            var toUpdate = _orderItems.FirstOrDefault(i => i.Id == orderItem.Id);
            if (toUpdate == null) throw new InvalidOperationException($"Order item with id {orderItem.Id} not found");

            toUpdate.SetProduct(orderItem.Product);
            toUpdate.SetQuantity(orderItem.Quantity);
        }

        public override string ToString()
        {
            return string.Join("\n", OrderItems.Select(i => $"{i.Product.Name} x{i.Quantity}"));
        }
    }
}