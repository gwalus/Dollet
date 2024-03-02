using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Models;

namespace Dollet.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        Monkey monkey;
        IConnectivity connectivity;
        //IToast toast;
        public MainPageViewModel(IConnectivity connectivity)
        {
            monkey = new Monkey { Name = "Mooch" };
            this.connectivity = connectivity;
            //this.toast = toast;
        }

        [ObservableProperty]
        int count;

        [RelayCommand]
        void IncrementCount()
        {
            if (count == 0)
            {

            }
            Count += 10;
        }

        [RelayCommand]
        Task Navigate() =>
            Shell.Current.GoToAsync($"{nameof(DetailPage)}?Count={Count}",
                new Dictionary<string, object>
                {
                    ["Monkey"] = monkey
                });

        [RelayCommand]
        async Task CheckInternet()
        {
            NetworkAccess accessType = connectivity.NetworkAccess;

            if (accessType == NetworkAccess.Internet)
            {
                //toast.MakeToast("You Have Internet!");
            }
            else
            {
                await Shell.Current.DisplayAlert("Check internet!", $"Current status: {accessType}", "OK");
            }
        }

    }
}
