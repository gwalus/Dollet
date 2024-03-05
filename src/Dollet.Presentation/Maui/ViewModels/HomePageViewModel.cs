using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Dollet.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        public HomePageViewModel()
        {
            //Title = "Home";
        }

        //[ObservableProperty]
        //string title;

        //[ObservableProperty]
        //string message;

        //[RelayCommand]
        //void UpdateMessage() => Message = "Hello from the ViewModel!";

        //[RelayCommand]
        //Task Navigate() =>
        //    Shell.Current.GoToAsync($"{nameof(DetailPage)}?Message={Message}");

        //[RelayCommand]
        //Task NavigateToMain() =>
        //    Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}
