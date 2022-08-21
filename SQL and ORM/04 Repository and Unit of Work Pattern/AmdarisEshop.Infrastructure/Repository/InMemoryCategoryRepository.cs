using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmdarisEshop.Infrastructure.Repository
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories;

        public InMemoryCategoryRepository()
        {
            _categories = new List<Category>();
        }
       
        public async Task Add(Category category)
        {
            _categories.Add(category);
        }

        public async Task<List<Category>> GetAll()
        {
            return _categories;
        }

        public async Task<Category> GetById(int categoryId)
        {
            var category = _categories
                .SingleOrDefault(p => p.CategoryId == categoryId);

            return category;
        }

        public void Remove(Category category)
        {
            _categories.Remove(category);
        }

        public Task Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
