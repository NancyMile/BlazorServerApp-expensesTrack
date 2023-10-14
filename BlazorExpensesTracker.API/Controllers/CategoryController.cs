using BlazorExpensesTracker.Data.Repositories;
using BlazorExpensesTracker.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlazorExpensesTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        //inject interfas
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoryRepository.GetAllCategories());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            return Ok(await GetCategory(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            if (category == null)
                return BadRequest();
            

            if (category.Name == string.Empty)
            {
                ModelState.AddModelError("Name","Category Name is required");
            }

            if (!ModelState.IsValid)
              return BadRequest(ModelState);
            

           var created = await _categoryRepository.InsertCategory(category);

            return Created("created", created);
        }

        [HttpPut]

        public async Task<IActionResult> UpdateCategory([FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest();
            }

            if (category.Name == String.Empty)
            {
                ModelState.AddModelError("Name", "Name is required");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _categoryRepository.UpdateCategory(category);
            return NoContent();
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id == 0)
                return BadRequest();

            await _categoryRepository.DeleteCategory(id);
            return NoContent();
        }

    }
}
