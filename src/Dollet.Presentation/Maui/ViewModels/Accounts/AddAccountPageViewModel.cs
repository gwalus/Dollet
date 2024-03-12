﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        public Icon SelectedIcon { get; set; }
        public string SelectedColor { get; set; }
        public string SelectedCurrency { get; set; }

        public AddAccountPageViewModel(IAccountRepository accountRepository, INavigationService navigationService)
        {
            _accountRepository = accountRepository;
            _navigationService = navigationService;
            Icons =
            [
                new Icon { Value = MaterialDesignIconFonts.Wallet },
                new Icon { Value = MaterialDesignIconFonts.Wallet_giftcard },
                new Icon { Value = MaterialDesignIconFonts.Wallet_membership },
                new Icon { Value = MaterialDesignIconFonts.Wallet_travel },
                new Icon { Value = MaterialDesignIconFonts.Account_balance },
                new Icon { Value = MaterialDesignIconFonts.Account_balance_wallet },
                new Icon { Value = MaterialDesignIconFonts.Account_box }
            ];

            Colors = new ObservableCollection<string>
            {
                "Red", "Yellow", "Pink", "Green", "Blue"
            };

            Currencies = new ObservableCollection<string>
            {
                "PLN", "EUR", "USD", "CHF", "GBP"
            };
        }

        [RelayCommand]
        async Task AddAccount()
        {
            var added = await _accountRepository.AddAsync(new Account
            {
                Ammount = Ammount,
                Name = Name,
                Icon = SelectedIcon.Value,
                Color = SelectedColor,
                Currency = SelectedCurrency
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
