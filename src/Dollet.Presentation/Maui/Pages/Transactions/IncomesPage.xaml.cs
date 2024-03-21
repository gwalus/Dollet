using Dollet.Helpers;
using Dollet.ViewModels.Transactions;

namespace Dollet.Pages.Transactions
{
    public partial class IncomesPage : ContentPage
    {
        public IncomesPage()
        {
            InitializeComponent();

            BindingContext = ServiceProviderHelper.GetService<IncomesPageViewModel>();
        }
    }
}