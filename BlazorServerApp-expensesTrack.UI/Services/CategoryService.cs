using BlazorExpensesTracker.Model;
using BlazorServerApp_expensesTrack.UI.Inferfaces;

namespace BlazorServerApp_expensesTrack.UI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryDetails(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
