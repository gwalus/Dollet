using Dollet.Helpers;
using Dollet.ViewModels.Accounts;

namespace Dollet.Pages.Accounts;

public partial class EditAccountPage : ContentPage
{
	public EditAccountPage()
	{
		InitializeComponent();

        BindingContext = ServiceProviderHelper.GetService<EditAccountPageViewModel>();
    }
}