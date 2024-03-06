namespace Dollet.Core.DAL
{
    internal static class Extensions
    {
        public static IServiceCollection AddDal(this IServiceCollection services)
        {
            services.AddDbContext<DolletDbContext>();

            EnsureCreated(services);

            return services;
        }

        private static void EnsureCreated(IServiceCollection services)
        {
            using var serviceProvider = services.BuildServiceProvider();
            var scope = serviceProvider.CreateScope();

            using var context = scope.ServiceProvider.GetRequiredService<DolletDbContext>();

            context.Database.EnsureCreated();
        }
    }
}
