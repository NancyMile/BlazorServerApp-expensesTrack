using System;
using System.Collections.Generic;
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

        public DateTime Transactiondate { get; set; }

        public ExpenseType ExpenseType { get; set; }

    }
}
