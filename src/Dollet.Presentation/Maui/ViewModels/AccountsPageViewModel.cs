using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Commands;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;

namespace Dollet.ViewModels
{
    public partial class AccountsPageViewModel : ObservableObject
    {
        private readonly IAccountRepository _accountRepository;

        public AddAccountCommand AddAccountCommand { get; }

        public AccountsPageViewModel(AddAccountCommand addAccount, IAccountRepository accountRepository)
        {
            AddAccountCommand = addAccount;
            _accountRepository = accountRepository;
        }

        [ObservableProperty]
        public IEnumerable<Account> accounts = new List<Account>
        {
            new Account
            {
                Icon = "1",
                Color = "Red",
                Name = "Main"
            },
            new Account
            {
                Icon = "1",
                Color = "Red",
                Name = "Main2"
            },
            new Account
            {
                Icon = "1",
                Color = "Red",
                Name = "Main3"
            }
        };


        [RelayCommand]
        async Task OnAppearing2(EventArgs eventArgs)
        {
            //var abc = await _accountRepository.GetAllAsync();

            //accounts = abc;
        }
    }
}
