using BlazorExpensesTracker.Model;

namespace BlazorServerApp_expensesTrack.UI.Inferfaces
{
    public interface IExpenseService
    {
        Task<IEnumerable<Expense>> GetAllExpenses();
        Task<Expense> GetExpenseDetails(int id);
        Task SaveExpense(Expense expense);
        Task DeleteExpense(int id);
    }
}
