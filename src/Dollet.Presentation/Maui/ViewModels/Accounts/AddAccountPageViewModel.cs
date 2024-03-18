using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using Dollet.Pages;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels.Accounts
{
    public partial class AddAccountPageViewModel : ObservableObject
    {
        private readonly IAccountRepository _accountRepository;

        public ObservableCollection<string> Icons { get; set; }
        public ObservableCollection<string> Colors { get; set; }
        public ObservableCollection<string> Currencies{ get; set; }

        public decimal Ammount { get; set; } = 0.00m;
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public string SelectedIcon { get; set; }
        public string SelectedColor { get; set; }
        public string SelectedCurrency { get; set; } = "PLN";
        public bool IsHidden { get; set; } = false;

        public AddAccountPageViewModel(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            Icons =
            [
                MaterialDesignIconFonts.Account_balance,
                MaterialDesignIconFonts.Account_balance_wallet,
                MaterialDesignIconFonts.Wallet,
                MaterialDesignIconFonts.Savings,
                MaterialDesignIconFonts.Credit_card,
                MaterialDesignIconFonts.Paid,
                MaterialDesignIconFonts.Euro,
                MaterialDesignIconFonts.Wallet_giftcard,
                MaterialDesignIconFonts.Currency_exchange
            ];

            Colors =
            [
                "#d2b7b7", "#a76e6e", "#88af95", "#819a78", "#7782b0", "#606a9f", "#e39e83", 
                "#855e5c", "#f7e2a9", "#d3bae1", "#f0e6ab", "#ffc8c8", "#979393", "#fe4f78"
            ];

            Currencies =
            [
                "PLN", "EUR", "USD", "CHF", "GBP"
            ];
        }

        [RelayCommand]
        async Task AddAccount()
        {
            var added = await _accountRepository.AddAsync(new Account
            {
                Ammount = Ammount,
                Description = Description,
                Name = Name,
                Icon = SelectedIcon,
                Color = SelectedColor,
                Currency = SelectedCurrency,
                IsHidden = IsHidden
            });

            if(added)
            {
                await Shell.Current.GoToAsync($"//{nameof(AccountsPage)}");
            }
        }
    }
}