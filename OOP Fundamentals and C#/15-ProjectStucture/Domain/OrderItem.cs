using System;

namespace Domain
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
            Quantity = quantity;
        }


        public int Id { get; set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public void SetProduct(Product product)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product));
        }
    }
}