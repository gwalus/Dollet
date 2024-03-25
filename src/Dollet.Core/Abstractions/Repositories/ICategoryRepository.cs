using Dollet.Core.Entities;

namespace Dollet.Core.Abstractions.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<bool> AddAsync(Category category);
    }
}
