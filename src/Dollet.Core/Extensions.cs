using Dollet.Core.DAL;
using Microsoft.EntityFrameworkCore;

namespace Dollet.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddDbContext<DolletDbContext>(options =>
                options.UseSqlite("Data Source=dollet.db;"));

            return services;
        }
    }
}
