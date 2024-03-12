using Dollet.Helpers;
using Dollet.ViewModels.Accounts;
using MauiIcons.Core;

namespace Dollet.Pages;

public partial class AddAccountPage : ContentPage
{
	public AddAccountPage()
	{
		InitializeComponent();

        BindingContext = ServiceProviderHelper.GetService<AddAccountPageViewModel>();

        _ = new MauiIcon();
    }
}