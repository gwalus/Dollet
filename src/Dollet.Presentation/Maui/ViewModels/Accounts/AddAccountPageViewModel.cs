using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using Dollet.Helpers;
using Dollet.Pages;
using MvvmHelpers;

namespace Dollet.ViewModels.Accounts
{
    public partial class AddAccountPageViewModel(IAccountRepository accountRepository) : ObservableObject
    {
        private readonly IAccountRepository _accountRepository = accountRepository;

        public ObservableRangeCollection<string> Icons { get; } = [];
        public ObservableRangeCollection<string> Colors { get; } = [];
        public ObservableRangeCollection<string> Currencies { get; } = [];

        public decimal Ammount { get; set; } = 0.00m;
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public string SelectedIcon { get; set; }
        public string SelectedColor { get; set; }
        public string SelectedCurrency { get; set; } = "PLN";
        public bool IsHidden { get; set; } = false;

        [RelayCommand]
        void Appearing()
        {
            var icons = Defined.Icons;
            Icons.AddRange(icons);

            var colors = Defined.Colors;
            Colors.AddRange(colors);

            var currencies = Defined.Currencies;
            Currencies.AddRange(currencies);
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

            if (added)
            {
                await Shell.Current.GoToAsync($"//{nameof(AccountsPage)}");
            }
        }
    }
}