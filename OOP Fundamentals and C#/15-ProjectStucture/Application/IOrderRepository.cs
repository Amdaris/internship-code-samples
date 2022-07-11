using System.Collections.Generic;
using Domain;

namespace Application
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        void AddItemToOrder(int orderId, OrderItem item);
        void Update(int orderId, OrderItem item);
        void DeleteOrderItem(int orderId, int orderItemId);
        Order GetOrder(int orderId);
        IEnumerable<Order> GetOrders();
    }
}