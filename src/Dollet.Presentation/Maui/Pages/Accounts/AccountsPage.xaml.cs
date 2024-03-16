using Dollet.Helpers;
using Dollet.ViewModels;

namespace Dollet.Pages;

public partial class AccountsPage : ContentPage
{
	public AccountsPage()
	{
		InitializeComponent();

		BindingContext = ServiceProviderHelper.GetService<AccountsPageViewModel>();
	}
}