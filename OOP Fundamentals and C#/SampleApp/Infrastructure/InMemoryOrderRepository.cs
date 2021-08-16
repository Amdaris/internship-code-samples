using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private List<Order> orders = new List<Order>();
        
        public void AddItemToOrder(int orderId, OrderItem item)
        {
            var order = orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
            {
                throw new InvalidOperationException($"Order with id {orderId} not found");
            }

            order.OrderItems.Add(item);
        }

        public void CreateOrder(Order order)
        {
            this.orders.Add(order);
        }

        public void DeleteOrderItem(int orderId, int orderItemId)
        {
            var order = orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null) 
            {
                throw new InvalidOperationException($"Order with id {orderId} not found");
            }

            var item = order.OrderItems.FirstOrDefault(i => i.Id == orderItemId);
            if (item == null) 
            {
                throw new InvalidOperationException($"Order item with id {orderItemId} not found");
            }

            order.OrderItems.Remove(item);
        }

        public Order GetOrder(int orderId)
        {
            return orders.FirstOrDefault(o => o.Id == orderId);
        }

        public void Update(int orderId, OrderItem item)
        {
            var order = orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
            {
                throw new InvalidOperationException($"Order with id {orderId} not found");
            }

            var toUpdate = order.OrderItems.FirstOrDefault(i => i.Id == item.Id);
            if (toUpdate == null)
            {
                throw new InvalidOperationException($"Order item with id {item.Id} not found");
            }

            toUpdate.Product = item.Product;
            toUpdate.Quantity = item.Quantity;
        }
    }
}
