using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExpensesTracker.Model
{
    public class Category
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Category Name required!")]
        public string Name { get; set; }
    }
}
