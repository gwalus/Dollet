using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Constants;
using Dollet.Infrastructure.DAL;
using Dollet.Pages.Transactions.Expenses;

namespace Dollet.ViewModels.Transactions.Expenses
{
    public class ExpensesGroup
    {
        public string Icon { get; set; }
        public string Category { get; set; }
        public decimal Percent { get; set; }
        public decimal Amount { get; set; }
    }

    public partial class ExpensesPageViewModel : ObservableObject
    {
        private readonly DolletDbContext _dbContext;

        public List<ExpensesGroup> Expenses { get; private set; } = [];

        public ExpensesPageViewModel(DolletDbContext dbContext)
        {
            Expenses.Add(new ExpensesGroup { Category = "Groceries", Amount = 10, Percent = 10, Icon = MaterialDesignIcons.Local_grocery_store });
            Expenses.Add(new ExpensesGroup { Category = "Activity", Amount = 50, Percent = 50, Icon = MaterialDesignIcons.Sports_baseball });
            Expenses.Add(new ExpensesGroup { Category = "Home", Amount = 40, Percent = 40, Icon = MaterialDesignIcons.House });
            Expenses.Add(new ExpensesGroup { Category = "Other", Amount = 40, Percent = 40, Icon = MaterialDesignIcons.House });
            Expenses.Add(new ExpensesGroup { Category = "Other2", Amount = 40, Percent = 40, Icon = MaterialDesignIcons.House });
            Expenses.Add(new ExpensesGroup { Category = "Other3", Amount = 40, Percent = 40, Icon = MaterialDesignIcons.House });
            Expenses.Add(new ExpensesGroup { Category = "Other4", Amount = 40, Percent = 40, Icon = MaterialDesignIcons.House });
            Expenses.Add(new ExpensesGroup { Category = "Other5", Amount = 40, Percent = 40, Icon = MaterialDesignIcons.House });
        }

        [RelayCommand]
        async Task NavigateToExpensesDetailsPage()
        {
            await Shell.Current.GoToAsync(nameof(ExpensesDetailsPage));
        }

        [RelayCommand]
        async Task NavigateToAddExpensePage()
        {
            await Shell.Current.GoToAsync(nameof(AddExpensePage));
        }
    }
}
