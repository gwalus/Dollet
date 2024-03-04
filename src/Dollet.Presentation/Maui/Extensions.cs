using Dollet.ViewModels;

namespace Dollet
{
    internal static class Extensions
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainPageViewModel>();
            services.AddTransient<DetailPageViewModel>();

            return services;
        }

        public static IServiceCollection AddPages(this IServiceCollection services)
        {
            services.AddSingleton<MainPage>();
            services.AddTransient<DetailPage>();

            return services;
        }
    }
}
