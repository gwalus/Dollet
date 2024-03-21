using Dollet.Helpers;
using Dollet.ViewModels.Transactions;

namespace Dollet.Pages.Transactions
{
    public partial class ExpensesPage : ContentPage
    {
        public ExpensesPage()
        {
            InitializeComponent();

            BindingContext = ServiceProviderHelper.GetService<ExpensesPageViewModel>();
        }
    }
}