using System;
using System.Collections.Generic;
using System.Linq;
using Application;
using Domain;

namespace Infrastructure
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public void AddItemToOrder(int orderId, OrderItem item)
        {
            var order = _orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) throw new InvalidOperationException($"Order with id {orderId} not found");

            order.AddOrderItem(item);
        }

        public void CreateOrder(Order order)
        {
            _orders.Add(order);
            order.Id = _orders.Count;
        }

        public void DeleteOrderItem(int orderId, int orderItemId)
        {
            var order = _orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) throw new InvalidOperationException($"Order with id {orderId} not found");

            var item = order.OrderItems.FirstOrDefault(i => i.Id == orderItemId);
            if (item == null) throw new InvalidOperationException($"Order item with id {orderItemId} not found");

            order.RemoveOrderItem(item);
        }

        public Order GetOrder(int orderId)
        {
            return _orders.FirstOrDefault(o => o.Id == orderId);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orders;
        }

        public void Update(int orderId, OrderItem item)
        {
            var order = _orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) throw new InvalidOperationException($"Order with id {orderId} not found");

            order.UpdateOrderItem(item);
        }
    }
}