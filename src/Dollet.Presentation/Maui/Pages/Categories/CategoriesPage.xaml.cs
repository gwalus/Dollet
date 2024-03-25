using Dollet.ViewModels.Categories;

namespace Dollet.Pages.Categories;

public partial class CategoriesPage : ContentPage
{
	public CategoriesPage(CategoriesPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}