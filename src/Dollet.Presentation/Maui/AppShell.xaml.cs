﻿using Dollet.Pages;
using Dollet.Pages.Accounts;
using Dollet.Pages.Categories;
using Dollet.Pages.Transactions;

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
            Routing.RegisterRoute("EditAccountPage", typeof(EditAccountPage));
            
            Routing.RegisterRoute("IncomesPage", typeof(IncomesPage));
            Routing.RegisterRoute("ExpensesPage", typeof(ExpensesPage));

            Routing.RegisterRoute("CategoriesPage", typeof(CategoriesPage));
            Routing.RegisterRoute("InwestmentsPage", typeof(InwestmentsPage));
            Routing.RegisterRoute("SettingsPage", typeof(SettingsPage));
        }
    }
}
