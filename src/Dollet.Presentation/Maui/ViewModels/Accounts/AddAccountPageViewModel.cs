using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using Dollet.Services;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels.Accounts
{
    public partial class AddAccountPageViewModel : ObservableObject
    {
        private readonly IAccountRepository _accountRepository;
        private readonly INavigationService _navigationService;

        public ObservableCollection<Icon> Icons { get; set; }
        public ObservableCollection<string> Colors { get; set; }
        public ObservableCollection<string> Currencies{ get; set; }

        public decimal Ammount { get; set; } = 0.00m;
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public Icon SelectedIcon { get; set; }
        public string SelectedColor { get; set; }
        public string SelectedCurrency { get; set; } = "PLN";
        public bool IsHidden { get; set; } = false;

        public AddAccountPageViewModel(IAccountRepository accountRepository, INavigationService navigationService)
        {
            _accountRepository = accountRepository;
            _navigationService = navigationService;
            Icons =
            [
                new Icon { Value = MaterialDesignIconFonts.Account_balance },
                new Icon { Value = MaterialDesignIconFonts.Account_balance_wallet },
                new Icon { Value = MaterialDesignIconFonts.Wallet },
                new Icon { Value = MaterialDesignIconFonts.Savings },
                new Icon { Value = MaterialDesignIconFonts.Credit_card },
                new Icon { Value = MaterialDesignIconFonts.Paid },
                new Icon { Value = MaterialDesignIconFonts.Euro },
                new Icon { Value = MaterialDesignIconFonts.Wallet_giftcard },
                new Icon { Value = MaterialDesignIconFonts.Currency_exchange }
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
                Icon = SelectedIcon.Value,
                Color = SelectedColor,
                Currency = SelectedCurrency,
                IsHidden = IsHidden
            });

            if(added)
            {
                await _navigationService.NavigateBackAsync();
            }
        }
    }

    public class Icon
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
