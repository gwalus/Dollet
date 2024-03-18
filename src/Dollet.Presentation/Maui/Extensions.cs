using Dollet.Commands;
using Dollet.Pages;
using Dollet.Pages.Accounts;
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
                .AddSingleton<WalletPage>()
                .AddSingleton<AccountsPage>()
                .AddTransient<AddAccountPage>()
                .AddTransient<EditAccountPage>()
                .AddSingleton<InwestmentsPage>()
                .AddSingleton<SettingsPage>();

        private static IServiceCollection AddViewModels(this IServiceCollection services) =>
            services
                .AddSingleton<WalletPageViewModel>()
                .AddSingleton<AccountsPageViewModel>()
                .AddTransient<AddAccountPageViewModel>()
                .AddTransient<EditAccountPageViewModel>()
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
