using AmdarisEshop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.Abstract
{
    public interface IProductRepository
    {
        Task<Product> GetById(int productId);
        Task Add(Product product);

        Task Save();
        void Remove(Product product);
        Task<List<Product>> GetAll();

        Task Update(Product product);
    }
}