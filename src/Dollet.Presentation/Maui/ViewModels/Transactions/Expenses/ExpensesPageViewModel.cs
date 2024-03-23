using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dollet.Helpers.Fonts;
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
        // - groceries x% kwota
        // - activity x% kwota

        //public List<ExpensesGroup> Expenses { get; private set; } = [];
        public List<ExpensesGroup> Expenses { get; private set; } = [];

        public ExpensesPageViewModel()
        {
            Expenses.Add(new ExpensesGroup { Category = "Groceries", Amount = 10, Percent = 10, Icon = MaterialDesignIcons.Local_grocery_store });
            Expenses.Add(new ExpensesGroup { Category = "Activity", Amount = 50, Percent = 50, Icon = MaterialDesignIcons.Sports_baseball });
            Expenses.Add(new ExpensesGroup { Category = "Home", Amount = 40, Percent = 40, Icon = MaterialDesignIcons.House });

            //Expenses.Add(new ExpensesGroup("Groceries",
            //[
            //    new() 
            //    {
            //        Amount = 10,
            //        Date = DateTime.Now,
            //        Comment = "Biedronka"
            //    },
            //    new() 
            //    {
            //        Amount = 20,
            //        Date = DateTime.Now,
            //        Comment = "Lidl"
            //    }
            //]));

            //Expenses.Add(new ExpensesGroup("Activity",
            //[
            //    new()
            //    {
            //        Amount = 30,
            //        Date = DateTime.Now.AddDays(-1),
            //        Comment = "Krykiet"
            //    },
            //    new()
            //    {
            //        Amount = 40,
            //        Date = DateTime.Now.AddDays(-1),
            //        Comment = "Tenis"
            //    },
            //    new() 
            //    {
            //        Amount = 50,
            //        Date = DateTime.Now.AddDays(-1),
            //        Comment = "Buty do biegania"
            //    }
            //]));

            //Expenses.Add(new ExpensesGroup("House",
            //[
            //    new()
            //    {
            //        Amount = 30,
            //        Date = DateTime.Now.AddDays(-1),
            //        Comment = "Nowa szafka"
            //    },
            //    new()
            //    {
            //        Amount = 40,
            //        Date = DateTime.Now.AddDays(-1),
            //        Comment = "Koc"
            //    }
            //]));

            //Expenses.Add(new ExpensesGroup("Other",
            //[
            //    new()
            //    {
            //        Amount = 10,
            //        Date = DateTime.Now,
            //        Comment = "Cos tam A"
            //    },
            //    new()
            //    {
            //        Amount = 20,
            //        Date = DateTime.Now,
            //        Comment = "Cos tam B"
            //    }
            //]));
        }

        [RelayCommand]
        async Task NavigateToExpensesDetailsPage()
        {
            await Shell.Current.GoToAsync(nameof(ExpensesDetailsPage));
        }
    }
}
