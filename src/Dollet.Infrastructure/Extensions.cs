using Dollet.Core.DAL;

namespace Dollet.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDataAccessLayer();

            return services;
        }   
    }
}