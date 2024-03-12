using Dollet.Helpers;
using Dollet.ViewModels.Accounts;

namespace Dollet.Pages;

public partial class AddAccountPage : ContentPage
{
	public AddAccountPage()
	{
		InitializeComponent();

        BindingContext = ServiceProviderHelper.GetService<AddAccountPageViewModel>();
    }
}