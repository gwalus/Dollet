using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using Dollet.Helpers.Fonts;
using Dollet.Pages;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels.Accounts
{
    public partial class AddAccountPageViewModel : ObservableObject
    {
        private readonly IAccountRepository _accountRepository;

        public ObservableCollection<string> Icons { get; private set; }
        public ObservableCollection<string> Colors { get; private set; }
        public ObservableCollection<string> Currencies { get; private set; }

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
            
            Icons = Defined.Icons;
            Colors = Defined.Colors;
            Currencies = Defined.Currencies;
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