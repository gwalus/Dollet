using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels
{
    public partial class AccountsPageViewModel : ObservableObject
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsPageViewModel(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public ObservableCollection<Account> Accounts { get; private set; } = [];

        [RelayCommand]
        async Task OnAppearing(EventArgs eventArgs)
        {
            var results = await _accountRepository.GetAllAsync();

            foreach (var item in results)
            {
                Accounts.Add(item);
            }
        }

        [RelayCommand]
        async Task AddAccount(EventArgs eventArgs)
        {

        }
    }
}
