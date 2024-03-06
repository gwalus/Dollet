using Dollet.Core.Abstractions.Repositories;
using Dollet.Infrastructure.Repositories;

namespace Dollet.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();

            return services;
        }
    }
}
