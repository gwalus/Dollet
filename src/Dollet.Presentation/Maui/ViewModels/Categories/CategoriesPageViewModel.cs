using CommunityToolkit.Mvvm.Input;
using Dollet.Core.Abstractions.Repositories;
using Dollet.Core.Entities;
using MvvmHelpers;

namespace Dollet.ViewModels.Categories
{
    public partial class CategoriesPageViewModel(ICategoryRepository categoryRepository) : ObservableObject
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public ObservableRangeCollection<Category> Categories { get; } = [];

        [RelayCommand]
        async Task Appearing()
        {
            Categories.AddRange(await _categoryRepository.GetAllAsync());
        }

        [RelayCommand]
        void Disappearing()
        {
            Categories.Clear();
        }
    }
}
