using CommunityToolkit.Mvvm.ComponentModel;
using Dollet.Core.Entities;

namespace Dollet.ViewModels.Transactions
{
    public class ExpensesPageViewModel : ObservableObject
    {
        public List<ExpensesGroup> Expenses { get; private set; } = [];

        public ExpensesPageViewModel()
        {
            Expenses.Add(new ExpensesGroup("Groceries",
            [
                new() 
                {
                    Amount = 10,
                    Date = DateTime.Now,
                    Comment = "Biedronka"
                },
                new() 
                {
                    Amount = 20,
                    Date = DateTime.Now,
                    Comment = "Lidl"
                }
            ]));

            Expenses.Add(new ExpensesGroup("Activity",
            [
                new()
                {
                    Amount = 30,
                    Date = DateTime.Now.AddDays(-1),
                    Comment = "Krykiet"
                },
                new()
                {
                    Amount = 40,
                    Date = DateTime.Now.AddDays(-1),
                    Comment = "Tenis"
                },
                new() 
                {
                    Amount = 50,
                    Date = DateTime.Now.AddDays(-1),
                    Comment = "Buty do biegania"
                }
            ]));

            Expenses.Add(new ExpensesGroup("House",
            [
                new()
                {
                    Amount = 30,
                    Date = DateTime.Now.AddDays(-1),
                    Comment = "Nowa szafka"
                },
                new()
                {
                    Amount = 40,
                    Date = DateTime.Now.AddDays(-1),
                    Comment = "Koc"
                }
            ]));

            Expenses.Add(new ExpensesGroup("Other",
            [
                new()
                {
                    Amount = 10,
                    Date = DateTime.Now,
                    Comment = "Cos tam A"
                },
                new()
                {
                    Amount = 20,
                    Date = DateTime.Now,
                    Comment = "Cos tam B"
                }
            ]));
        }
    }

    public class ExpensesGroup : List<Expense>
    {
        public string CategoryName { get; private set; }

        public ExpensesGroup(string categoryName, List<Expense> expenses) : base(expenses)
        {
            CategoryName = categoryName;
        }
    }
}
