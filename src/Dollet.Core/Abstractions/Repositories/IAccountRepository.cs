using Dollet.Core.Entities;

namespace Dollet.Core.Abstractions.Repositories
{
    public interface IAccountRepository
    {
        Task<Account> GetAsync(int id);
        Task<IEnumerable<Account>> GetAllAsync();
        Task<bool> AddAsync(Account account);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Account account);
    }
}
