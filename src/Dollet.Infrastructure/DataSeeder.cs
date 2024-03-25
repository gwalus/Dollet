using Dollet.Core.Constants;
using Dollet.Core.Entities;
using Dollet.Infrastructure.DAL;

namespace Dollet.Infrastructure
{
    public static class DataSeeder
    {
        public static async Task SeedAsync(IServiceCollection services)
        {
            using var serviceProvider = services.BuildServiceProvider();
            var scope = serviceProvider.CreateScope();

            using var context = scope.ServiceProvider.GetRequiredService<DolletDbContext>();

            await context.Database.EnsureCreatedAsync();
            await CategorySeedsAsync(context);
        }

        private static async Task CategorySeedsAsync(DolletDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new() { Name = "Groceries", Icon = MaterialDesignIcons.Local_grocery_store, Color = "#d2b7b7" },
                    new() { Name = "Activity", Icon = MaterialDesignIcons.Sports_baseball, Color = "#a76e6e" },
                    new() { Name = "Entertaiments", Icon = MaterialDesignIcons.Sports_bar, Color = "#88af95" },
                    new() { Name = "Restaurants", Icon = MaterialDesignIcons.Restaurant, Color = "#819a78" },
                    new() { Name = "House", Icon = MaterialDesignIcons.House, Color = "#7782b0" },
                    new() { Name = "Education", Icon = MaterialDesignIcons.Science, Color = "#606a9f" },
                    new() { Name = "Subscriptions", Icon = MaterialDesignIcons.Subscriptions, Color = "#e39e83" },
                    new() { Name = "Cafes", Icon = MaterialDesignIcons.Local_cafe, Color = "#819a78" },
                    new() { Name = "Other", Icon = MaterialDesignIcons.Done_all, Color = "#d2b7b7" }
                };

                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();
            }
        }
    }
}
