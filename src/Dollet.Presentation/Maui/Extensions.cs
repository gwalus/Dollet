using Dollet.Pages;
using Dollet.ViewModels;

namespace Dollet
{
    internal static class Extensions
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddPages();
            services.AddViewModels();

            return services;
        }

        private static IServiceCollection AddPages(this IServiceCollection services) =>
            services
                .AddSingleton<HomePage>()
                .AddSingleton<MainPage>()
                .AddSingleton<WalletPage>()
                .AddSingleton<AccountsPage>()
                .AddSingleton<InwestmentsPage>()
                .AddSingleton<SettingsPage>();

        private static IServiceCollection AddViewModels(this IServiceCollection services) => 
            services
                .AddSingleton<MainPageViewModel>()
                .AddTransient<DetailPageViewModel>();
    }
}
