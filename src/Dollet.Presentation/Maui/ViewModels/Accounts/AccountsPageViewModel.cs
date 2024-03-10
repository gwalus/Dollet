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

        public ObservableCollection<Account> Accounts { get; private set; } = [];

        [RelayCommand]
        async Task OnAppearing(EventArgs eventArgs)
        {
            //var results = await _accountRepository.GetAllAsync();

            //Accounts.Clear();

            //foreach (var item in results)
            //{
            //    Accounts.Add(item);
            //}
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

            //var results = await _accountRepository.GetAllAsync();

            //if (Accounts.Any())
            //{
            //    var difference = results.Except(Accounts).ToList();

            //    foreach (var item in difference)
            //    {
            //        Accounts.Add(item);
            //    }

            //    return;
            //}

            //foreach (var item in results)
            //{
            //    Accounts.Add(item);
            //}
        }

        [RelayCommand]
        async Task NavigateToAddAccountPage()
        {
            await _navigationService.NavigateToAsync<AddAccountPage>();
        }
    }
}
