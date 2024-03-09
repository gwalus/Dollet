using System.Diagnostics;

namespace Dollet.Services
{
    public class NavigationService(IServiceProvider services) : INavigationService
    {
        readonly IServiceProvider _services = services;

        protected static INavigation Navigation
        {
            get
            {
                INavigation? navigation = Application.Current?.MainPage?.Navigation;
                if (navigation is not null)
                    return navigation;
                else
                {
                    if (Debugger.IsAttached)
                        Debugger.Break();
                    throw new Exception();
                }
            }
        }

        public Task NavigateToAsync<T>() where T : Page
        {
            var page = ResolvePage<T>();
            
            if (page is not null)
                return Navigation.PushAsync(page, true);
            
            throw new InvalidOperationException($"Unable to resolve type {typeof(T).FullName}");
        }

        public Task NavigateBack()
        {
            if (Navigation.NavigationStack.Count > 1)
                return Navigation.PopAsync();

            throw new InvalidOperationException("No pages to navigate back to!");
        }

        private T? ResolvePage<T>() where T : Page
            => _services.GetService<T>();
    }
}