using CommunityToolkit.Mvvm.ComponentModel;
using Dollet.Core.Entities;
using Dollet.Helpers.Fonts;
using System.Collections.ObjectModel;

namespace Dollet.ViewModels.Categories
{
    public partial class CategoriesPageViewModel : ObservableObject
    {
        public ObservableCollection<Category> Categories { get; set; }

        public CategoriesPageViewModel()
        {
            Categories =
            [
                new Category { Name = "Groceries", Icon = MaterialDesignIcons.Local_grocery_store, Color = "#d2b7b7" },
                new Category { Name = "Activity", Icon = MaterialDesignIcons.Sports_baseball, Color = "#a76e6e" },
                new Category { Name = "Entertaiments", Icon = MaterialDesignIcons.Sports_bar, Color = "#88af95" },
                new Category { Name = "Restaurants", Icon = MaterialDesignIcons.Restaurant, Color = "#819a78" },
                new Category { Name = "House", Icon = MaterialDesignIcons.House, Color = "#7782b0" },
                new Category { Name = "Education", Icon = MaterialDesignIcons.Science, Color = "#606a9f" },
                new Category { Name = "Subscriptions", Icon = MaterialDesignIcons.Subscriptions, Color = "#e39e83" },
                new Category { Name = "Cafes", Icon = MaterialDesignIcons.Local_cafe, Color = "#819a78" },
                new Category { Name = "Other", Icon = MaterialDesignIcons.Done_all, Color = "#d2b7b7" }
            ];
        }
    }
}
