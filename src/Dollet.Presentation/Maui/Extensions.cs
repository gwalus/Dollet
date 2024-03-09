using Dollet.Commands;
using Dollet.Pages;
using Dollet.Services;
using Dollet.ViewModels;
using Dollet.ViewModels.Accounts;

namespace Dollet
{
    internal static class Extensions
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddPages();
            services.AddViewModels();
            services.AddCommands();
            services.AddServices();

            return services;
        }

        private static IServiceCollection AddPages(this IServiceCollection services) =>
            services
                .AddSingleton<HomePage>()
                .AddSingleton<WalletPage>()
                .AddSingleton<AccountsPage>()
                .AddSingleton<AddAccountPage>()
                .AddSingleton<InwestmentsPage>()
                .AddSingleton<SettingsPage>();

        private static IServiceCollection AddViewModels(this IServiceCollection services) =>
            services
                .AddSingleton<HomePageViewModel>()
                .AddSingleton<WalletPageViewModel>()
                .AddSingleton<AccountsPageViewModel>()
                .AddSingleton<AddAccountPageViewModel>()
                .AddSingleton<InwestmentsPageViewModel>()
                .AddSingleton<SettingsPageViewModel>();

        private static IServiceCollection AddCommands(this IServiceCollection services) =>
            services
                .AddTransient<AddAccountCommand>();

        private static IServiceCollection AddServices(this IServiceCollection services) =>
            services
                .AddSingleton<INavigationService, NavigationService>();
    }
}
