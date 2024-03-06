using Dollet.Core.DAL;

namespace Dollet.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddDal();

            return services;
        }
    }
}
