using System.Collections.Generic;
using Domain;

namespace Application
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void CreateProduct(Product product);
    }
}