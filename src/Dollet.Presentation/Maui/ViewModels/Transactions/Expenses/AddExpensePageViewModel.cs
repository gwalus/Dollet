using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using MvvmHelpers;

namespace Dollet.ViewModels.Transactions.Expenses
{
    public partial class AddExpensePageViewModel(IAccountRepository accountRepository, ICategoryRepository categoryRepository) : ObservableObject
    {
        private readonly IAccountRepository _accountRepository = accountRepository;
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public decimal Amount { get; set; }
        public string SelectedAccount { get; set; }
        public string SelectedCategory { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        //public ObservableRangeCollection<Account> Accounts = [];
        public ObservableRangeCollection<string> Accounts { get; } = [];
        public ObservableRangeCollection<string> Categories { get; } = [];

        [RelayCommand]
        async Task Appearing()
        {
            var accounts = await _accountRepository.GetAllAsync();

            var categories = await _categoryRepository.GetAllAsync();

            Accounts.AddRange(accounts.Select(x => x.Name));
            Categories.AddRange(categories.Select(x => x.Name));
        }

        [RelayCommand]
        async Task AddExpense()
        {
            return;
        }
    }
}
