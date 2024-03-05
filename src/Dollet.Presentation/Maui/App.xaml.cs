using Dollet.Pages;

namespace Dollet
{
    public partial class App : Application
    {
        public App(HomePage homePage)
        {
            InitializeComponent();

            MainPage = homePage;
        }
    }
}
