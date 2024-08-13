using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface ISubCategoryService
    {
        Task <ActionResult<SubCategory>?>GetSubCategoryById(int id);
        Task<ActionResult<IEnumerable<SubCategory>>> GetAllSubCategories();
        Task<ActionResult<SubCategory>> CreateSubCatgory(SubCategory subcategory);
        Task<ActionResult<SubCategory>> UpdateSubCategory(int subcategory_id,SubCategory subcategory);
        Task<SubCategory>DeleteSubCategory(int subcategory_id);
    }
}
