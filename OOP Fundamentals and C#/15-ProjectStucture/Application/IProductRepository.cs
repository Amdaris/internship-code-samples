using Domain;
using System.Collections.Generic;

namespace Application
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
    }
}
