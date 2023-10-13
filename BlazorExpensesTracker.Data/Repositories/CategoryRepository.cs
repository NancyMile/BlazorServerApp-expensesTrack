using BlazorExpensesTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExpensesTracker.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        //connect to db
        private SqlConfiguration _connectionString;

        public CategoryRepository(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        //method  to connect with db
        protected SqlConnection dbconnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public Task<bool> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
