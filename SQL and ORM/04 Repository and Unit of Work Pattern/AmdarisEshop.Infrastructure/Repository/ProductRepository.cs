using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Infrastructure;
using AmdarisEshop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmdarisEshop.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products
                .Include(p => p.Categories)
                .Take(100)
                .ToListAsync();
        }

        public async Task<Product> GetById(int productId)
        {
            var product = await _context.Products
                .Include(p => p.Categories)
                .SingleOrDefaultAsync(p => p.ProductId == productId);

            return product;
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
        }

        public async Task Update(Product product)
        {
            _context.Update(product);
        }
    }
}
