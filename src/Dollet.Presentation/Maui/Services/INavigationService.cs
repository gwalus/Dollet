namespace Dollet.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<T>() where T : Page;
        Task NavigateBackAsync();
    }
}