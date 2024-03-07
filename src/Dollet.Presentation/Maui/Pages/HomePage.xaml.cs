using Dollet.Helpers;
using Dollet.ViewModels;

namespace Dollet.Pages;

public partial class HomePage : TabbedPage
{
	public HomePage()
	{
		InitializeComponent();

		BindingContext = ServiceProviderHelper.GetService<HomePageViewModel>();
    }
}