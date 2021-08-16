using Application;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class InMemoryProductRepository : IProductRepository
    {
        private List<Product> products;
        public InMemoryProductRepository()
        {
            this.products = new List<Product>
            {
                new Product { Id = 1, Name = "Frigider", Price = 1000 },
                new Product { Id = 2, Name = "Telefon", Price = 2500 },
                new Product { Id = 3, Name = "Laptop", Price = 4000 },
                new Product { Id = 4, Name = "Televizor", Price = 3000 },
                new Product { Id = 5, Name = "Aragaz", Price = 1500 },
            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
