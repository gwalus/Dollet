using Dollet.Commands;
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
            services.AddCommands();

            return services;
        }

        private static IServiceCollection AddPages(this IServiceCollection services) =>
            services
                .AddSingleton<HomePage>()
                .AddSingleton<WalletPage>()
                .AddSingleton<AccountsPage>()
                .AddSingleton<InwestmentsPage>()
                .AddSingleton<SettingsPage>();

        private static IServiceCollection AddViewModels(this IServiceCollection services) =>
            services
                .AddSingleton<HomePageViewModel>()
                .AddSingleton<WalletPageViewModel>()
                .AddSingleton<InwestmentsPageViewModel>()
                .AddSingleton<AccountsPageViewModel>()
                .AddSingleton<SettingsPageViewModel>();

        private static IServiceCollection AddCommands(this IServiceCollection services) =>
            services
                .AddTransient<AddAccountCommand>();
    }
}
