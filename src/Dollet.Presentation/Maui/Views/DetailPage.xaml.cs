using Dollet.ViewModels;

namespace Dollet
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(DetailPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}