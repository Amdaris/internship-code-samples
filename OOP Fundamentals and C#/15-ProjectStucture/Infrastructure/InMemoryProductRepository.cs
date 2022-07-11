using System.Collections.Generic;
using System.Linq;
using Application;
using Domain;

namespace Infrastructure
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public InMemoryProductRepository()
        {
            _products = new List<Product>
            {
                new("Frigider", 1000) { Id = 1 },
                new("Telefon", 2500) { Id = 2 },
                new("Laptop", 4000) { Id = 3 }
            };
        }

        public void CreateProduct(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}