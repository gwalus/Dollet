using Dollet.Pages;

namespace Dollet
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("WalletPage", typeof(WalletPage));
            Routing.RegisterRoute("AccountsPage", typeof(AccountsPage));
            Routing.RegisterRoute("AddAccountPage", typeof(AddAccountPage));
            Routing.RegisterRoute("InwestmentsPage", typeof(InwestmentsPage));
            Routing.RegisterRoute("SettingsPage", typeof(SettingsPage));
        }
    }
}
