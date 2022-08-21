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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories
                .Take(100)
                .ToListAsync();
        }

        public async Task<Category> GetById(int categoryId)
        {
            var category = await _context.Categories
                .SingleOrDefaultAsync(p => p.CategoryId == categoryId);

            return category;
        }

        public void Remove(Category category)
        {
            _context.Categories.Remove(category);
        }

        public async Task Update(Category category)
        {
            _context.Update(category);
        }

       
    }
}
