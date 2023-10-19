using BlazorExpensesTracker.Model.validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExpensesTracker.Model
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        [Range(1, double.MaxValue,ErrorMessage = "Amounts needs to be greather than zero.")]
        public decimal Amount { get; set; }
        [Required]
        public string CategoryId { get; set; }

        //public Category category { get; set; }
        public Category Category { get; set; }
        [Required]
        [ExpenseTransactionDateValidator(DaysInTheFuture = 30)]
        public DateTime TransactionDate { get; set; }

        public ExpenseType ExpenseType { get; set; }

        public event Action OnSelectedExpenseChanged;
        public void SelectedExpenseChanged(Expense expense)
        {
            Id = expense.Id;
            Amount = expense.Amount;
            CategoryId = expense.CategoryId;
            ExpenseType = expense.ExpenseType;
            TransactionDate = expense.TransactionDate;
            NotifySelectedExpenseChanged();
        }

        private void NotifySelectedExpenseChanged()
        {
            OnSelectedExpenseChanged.Invoke();
        }
        
    }
}
