using BlazorExpensesTracker.Model;

namespace BlazorServerApp_expensesTrack.UI.Inferfaces
{
    public interface ICategoryService
    {

        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryDetails(int id);
        Task<bool> SaveCategory(Category category);
        Task<bool> DeleteCategory(int id);
    }
}
