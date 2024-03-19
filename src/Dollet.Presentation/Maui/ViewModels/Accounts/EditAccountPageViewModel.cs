using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels.Accounts
{
    [QueryProperty(nameof(Account), "Account")]
    public partial class EditAccountPageViewModel : ObservableObject
    {
        private Account account;

        public Account Account
        {
            get => account;
            set
            {
                SetProperty(ref account, value);
            }
        }

        public ObservableCollection<string> Icons { get; private set; }
        public ObservableCollection<string> Colors { get; private set; }
        public ObservableCollection<string> Currencies { get; private set; }
        
        private readonly IAccountRepository _accountRepository;

        public EditAccountPageViewModel(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;

            Icons = Defined.Icons;
            Colors = Defined.Colors;
            Currencies = Defined.Currencies;
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