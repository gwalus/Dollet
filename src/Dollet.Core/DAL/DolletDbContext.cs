using Dollet.Core.DAL.Helpers;
using Dollet.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dollet.Core.DAL
{
    public class DolletDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var name = DatabasePath.GetPath("dollet.db");

            optionsBuilder.UseSqlite($"Filename={name}");
        }
    }
}
