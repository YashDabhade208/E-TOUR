using eTour.Model;
using eTour.Service;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Controllers
{
    [Route("api/subcategory")]
    [ApiController]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService service;

        public SubCategoryController(ISubCategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategory>?>> GetAllSubCategory()
        {
            return await service.GetAllSubCategories();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategory>> GetSubCategoryById(int subcategory_id)
        {
            return await service.GetSubCategoryById(subcategory_id);
        }


        [HttpPost]
        public async Task<ActionResult<SubCategory>> CreateSubCategory(SubCategory subcategory)
        {
            return await service.CreateSubCatgory(subcategory);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateSubCategory(int subcategory_id, SubCategory subcategory)
        {
            if (subcategory_id != subcategory.Subcategory_Id)
            {
                return BadRequest();
            }
            try
            {
                await service.UpdateSubCategory(subcategory_id, subcategory);
            }
            catch
            {
                Console.WriteLine("NOT UPDATED.");
            }
            return NoContent();

        }
    }
}
