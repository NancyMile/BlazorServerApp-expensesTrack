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
        public decimal Amount { get; set; }
        public string CategoryId { get; set; }

        public Category category { get; set; }

        [Required]
        [ExpenseTransactionDateValidator(DaysInTheFuture = 30)]
        public DateTime Transactiondate { get; set; }

        public ExpenseType ExpenseType { get; set; }

    }
}
