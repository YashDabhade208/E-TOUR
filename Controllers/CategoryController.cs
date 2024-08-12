using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace eTour.Controllers
{

    [Route("api/category")]
    [ApiController]
    public class CategoryController:ControllerBase
    {

        private readonly ICategoryService service;


        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>?>>GetAllCategory()
        {
            return await service.GetAllCategory();
        }



        [HttpGet("/{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int category_id)
        {
            return await service.GetCategoryById(category_id);
        }




        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            return await service.CreateCategory(category);
        }



        [HttpPut("/{id}")]
        public async Task<IActionResult> UpdateCategory(int category_id,Category category)
        {
            if(category_id!=category.Category_id)
            {
                return BadRequest();
            }
            try
            {
                await service.UpdateCategory(category_id, category);
            }
            catch
            {
                Console.WriteLine("NOT UPDATED");
            }

            return NoContent();
        }

        
    }
            
    
}
