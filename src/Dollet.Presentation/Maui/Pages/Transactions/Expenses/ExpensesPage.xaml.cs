using Dollet.Helpers;
using Dollet.ViewModels.Transactions.Expenses;

namespace Dollet.Pages.Transactions.Expenses
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