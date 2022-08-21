using System;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository ProductRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        Task Save();
    }
}
