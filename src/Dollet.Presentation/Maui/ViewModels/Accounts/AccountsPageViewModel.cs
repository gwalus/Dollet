using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using Dollet.Pages;
using Dollet.Pages.Accounts;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels.Accounts
{
    public partial class AccountsPageViewModel : ObservableObject
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsPageViewModel(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        private decimal _accountsBalanceInDefaultCurrency;

        private decimal accountsBalance;

        public decimal AccountsBalance { get => accountsBalance; set => SetProperty(ref accountsBalance, value); }
        public string SelectedCurrency { get; set; }

        ObservableCollection<Account> accounts = [];
        public ObservableCollection<Account> Accounts { get => accounts; set => SetProperty(ref accounts, value); }

        ObservableCollection<Account> hiddenAccounts = [];
        public ObservableCollection<Account> HiddenAccounts { get => hiddenAccounts; set => SetProperty(ref hiddenAccounts, value); }

        ObservableCollection<string> currencies = [];
        public ObservableCollection<string> Currencies { get => currencies; set => SetProperty(ref currencies, value); }

        [RelayCommand]
        async Task NavigatedTo()
        {
            var results = await _accountRepository.GetAllAsync();

            Accounts = [];
            HiddenAccounts = [];
            Currencies = [];

            foreach (var item in results.GroupBy(r => r.IsHidden))
            {
                foreach (var abc in item)
                {
                    if (abc.IsHidden)
                    {
                        HiddenAccounts.Add(abc);
                        continue;
                    }
                    Accounts.Add(abc);
                }
            }

            _accountsBalanceInDefaultCurrency = Accounts.Sum(x => x.Ammount);

            AccountsBalance = _accountsBalanceInDefaultCurrency;

            Currencies = Defined.Currencies;
        }

        [RelayCommand]
        async Task CurrencyChanged()
        {
            if (_accountsBalanceInDefaultCurrency == 0)
            {
                AccountsBalance = 0;
                return;
            }

            // IT'S NOT CORRECTLY, but for test
            if (SelectedCurrency == "EUR")
            {
                AccountsBalance = _accountsBalanceInDefaultCurrency / 4.5m;
                return;
            }

            if (SelectedCurrency == "USD")
            {
                AccountsBalance = _accountsBalanceInDefaultCurrency / 4.0m;
                return;
            }

            if (SelectedCurrency == "CHF")
            {
                AccountsBalance = _accountsBalanceInDefaultCurrency / 5.0m;
                return;
            }

            if (SelectedCurrency == "PLN")
            {
                AccountsBalance = _accountsBalanceInDefaultCurrency;
                return;
            }
        }

        [RelayCommand]
        async Task NavigateToAddAccountPage()
        {
            await Shell.Current.GoToAsync(nameof(AddAccountPage));
        }

        [RelayCommand]
        async Task NavigateToEditAccountPage(Account account)
        {
            await Shell.Current.GoToAsync(nameof(EditAccountPage), true, new Dictionary<string, object>
            {
                {$"{nameof(Account)}", account }
            });
        }
    }
}
