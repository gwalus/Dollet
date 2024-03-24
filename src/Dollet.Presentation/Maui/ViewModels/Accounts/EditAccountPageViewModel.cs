using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using MvvmHelpers;

namespace Dollet.ViewModels.Accounts
{
    [QueryProperty(nameof(Account), "Account")]
    public partial class EditAccountPageViewModel(IAccountRepository accountRepository) : ObservableObject
    {
        private Account account;
        public Account Account { get => account; set { SetProperty(ref account, value); } }

        public ObservableRangeCollection<string> Icons { get; } = [];
        public ObservableRangeCollection<string> Colors { get; } = [];
        public ObservableRangeCollection<string> Currencies { get; } = [];
        
        private readonly IAccountRepository _accountRepository = accountRepository;

        [RelayCommand]
        void Appearing()
        {
            var icons = Defined.Icons;
            Icons.AddRange(icons);

            var colors = Defined.Colors;
            Colors.AddRange(colors);

            var currencies = Defined.Currencies;
            Currencies.AddRange(currencies);
        }

        [RelayCommand]
        async Task EditAccount()
        {
            if(await _accountRepository.UpdateAsync(Account))
            {
                var toast = Toast.Make("Edited successfully", ToastDuration.Short, 14);

                await toast.Show();
            }
            else
            {
                var toast = Toast.Make("Something went wrong...", ToastDuration.Short, 14);

                await toast.Show();
            }
        }
    }
}