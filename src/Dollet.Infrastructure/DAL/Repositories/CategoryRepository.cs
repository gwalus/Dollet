using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dollet.Infrastructure.DAL.Repositories
{
    internal class CategoryRepository(DolletDbContext dbContext) : ICategoryRepository
    {
        private readonly DolletDbContext _dbContext = dbContext;

        public async Task<bool> AddAsync(Category category)
        {
            await _dbContext.Categories.AddAsync(category);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}
