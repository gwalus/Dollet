using Dollet.Helpers;
using Dollet.ViewModels.Categories;

namespace Dollet.Pages.Categories;

public partial class CategoriesPage : ContentPage
{
	public CategoriesPage()
	{
		InitializeComponent();

        BindingContext = ServiceProviderHelper.GetService<CategoriesPageViewModel>();
    }
}