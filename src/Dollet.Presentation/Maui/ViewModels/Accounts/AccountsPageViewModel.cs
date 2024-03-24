using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using Dollet.Pages;
using Dollet.Pages.Accounts;
using MvvmHelpers;

namespace Dollet.ViewModels.Accounts
{
    public partial class AccountsPageViewModel(IAccountRepository accountRepository) : ObservableObject
    {
        private readonly IAccountRepository _accountRepository = accountRepository;
        
        private decimal _accountsBalanceInDefaultCurrency;

        private decimal accountsBalance;
        public decimal AccountsBalance { get => accountsBalance; set => SetProperty(ref accountsBalance, value); }
        
        public string SelectedCurrency { get; set; }

        public ObservableRangeCollection<Account> Accounts { get; } = [];
        public ObservableRangeCollection<Account> HiddenAccounts { get; } = [];
        public ObservableRangeCollection<string> Currencies { get; } = [];

        [RelayCommand]
        async Task NavigatedTo()
        {
            var results = await _accountRepository.GetAllAsync();

            Accounts.Clear();
            HiddenAccounts.Clear();
            Currencies.Clear();

            foreach (var item in results.GroupBy(r => r.IsHidden))
            {
                if (item.Key)
                {
                    HiddenAccounts.AddRange(item);
                    continue;
                }
                Accounts.AddRange(item);
            }

            _accountsBalanceInDefaultCurrency = Accounts.Sum(x => x.Ammount);

            AccountsBalance = _accountsBalanceInDefaultCurrency;

            var currencies = Defined.Currencies;
            Currencies.AddRange(currencies);
        }

        [RelayCommand]
        void CurrencyChanged()
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
