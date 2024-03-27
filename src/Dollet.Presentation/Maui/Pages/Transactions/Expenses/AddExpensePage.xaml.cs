using Dollet.Helpers;
using Dollet.ViewModels.Transactions.Expenses;

namespace Dollet.Pages.Transactions.Expenses;

public partial class AddExpensePage : ContentPage
{
	public AddExpensePage()
	{
		InitializeComponent();

		BindingContext = ServiceProviderHelper.GetService<AddExpensePageViewModel>();
	}
}