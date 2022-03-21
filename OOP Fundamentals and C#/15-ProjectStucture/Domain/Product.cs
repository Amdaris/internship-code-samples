using System;

namespace Domain
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; init; }
        public double Price { get; init; }
    }
}