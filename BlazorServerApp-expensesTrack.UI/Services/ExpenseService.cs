using BlazorExpensesTracker.Model;
using BlazorServerApp_expensesTrack.UI.Inferfaces;
using System.Text;
using System.Text.Json;

namespace BlazorServerApp_expensesTrack.UI.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly HttpClient _httpClient;

        public ExpenseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task DeleteExpense(int id)
        {
            await _httpClient.DeleteAsync($"api/expense/{id}");
        }
        public async Task<IEnumerable<Expense>> GetAllExpenses()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Expense>>(
                await _httpClient.GetStreamAsync($"api/expense/"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<Expense> GetExpenseDetails(int id)
        {
            return await JsonSerializer.DeserializeAsync<Expense>(
                await _httpClient.GetStreamAsync($"api/expense/{id}"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task SaveExpense(Expense expense)
        {
            var expenseJson = new StringContent(JsonSerializer.Serialize(expense),
                Encoding.UTF8, "application/json");

            if (expense.Id == 0)
            {
                await _httpClient.PostAsync("api/expense", expenseJson); ;
            }
            else
            {
                await _httpClient.PutAsync("api/expense", expenseJson);
            }
        }
    }
}
