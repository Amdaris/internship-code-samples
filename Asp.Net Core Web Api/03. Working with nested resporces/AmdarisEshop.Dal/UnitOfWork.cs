using AmdarisEshop.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisEshop.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataCOntext, IProductRepository productRepository,
            ICategoryReporitory categoryRepository)
        {
            _dataContext = dataCOntext;
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
        }

        public IProductRepository ProductRepository { get; private set; }
        public ICategoryReporitory CategoryRepository { get; private set; }

        

        public async Task Save()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
