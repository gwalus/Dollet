using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Pages;
using Dollet.Services;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels
{
    public partial class AccountsPageViewModel : ObservableObject
    {
        private readonly IAccountRepository _accountRepository;
        private readonly INavigationService _navigationService;

        public AccountsPageViewModel(IAccountRepository accountRepository, INavigationService navigationService)
        {
            _accountRepository = accountRepository;
            _navigationService = navigationService;
        }

        private decimal _accountsBalanceInDefaultCurrency;

        private decimal accountsBalance;

        public decimal AccountsBalance { get => accountsBalance; set => SetProperty(ref accountsBalance, value); }

        public string SelectedCurrency { get; set; }

        public ObservableCollection<Account> Accounts { get; private set; } = [];
        
        public ObservableCollection<string> Currencies { get; private set; } = [];

        [RelayCommand]
        async Task OnAppearing(EventArgs eventArgs)
        {

        }

        [RelayCommand]
        async Task NavigatedTo()
        {
            var results = await _accountRepository.GetAllAsync();

            Accounts.Clear();

            foreach (var item in results)
            {
                Accounts.Add(item);
            }

            _accountsBalanceInDefaultCurrency = Accounts.Sum(x => x.Ammount);

            AccountsBalance = _accountsBalanceInDefaultCurrency;

            Currencies.Clear();

            Currencies.Add("PLN");
            Currencies.Add("EUR");
            Currencies.Add("USD");
            Currencies.Add("CHF");
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
            await _navigationService.NavigateToAsync<AddAccountPage>();
        }
    }
}
