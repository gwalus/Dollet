using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dollet.Infrastructure.DAL.Repositories
{
    internal class AccountRepository(DolletDbContext dbContext) : IAccountRepository
    {
        private readonly DolletDbContext _dbContext = dbContext;

        public async Task<bool> AddAsync(Account account)
        {
            _dbContext.Accounts.Add(account);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _dbContext.Remove(id);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            return await _dbContext.Accounts.ToListAsync();
        }

        public async Task<Account> GetAsync(int id)
        {
            return await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Account account)
        {
            _dbContext.Accounts.Update(account);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
