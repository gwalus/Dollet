using Dollet.Core.Abstractions.Repositories;
using Dollet.Infrastructure.DAL;
using Dollet.Infrastructure.DAL.Repositories;

namespace Dollet.Core.DAL
{
    internal static class Extensions
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
        {
            services.AddDbContext<DolletDbContext>();

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }        
    }
}
