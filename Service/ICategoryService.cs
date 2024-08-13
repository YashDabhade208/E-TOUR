    using eTour.Model;
using Microsoft.AspNetCore.Mvc;

namespace eTour.Service
{
    public interface ICategoryService
    {
        Task<ActionResult<Category>?>GetCategoryById(int id);
        Task<ActionResult<IEnumerable<Category>>> GetAllCategory();
        Task<ActionResult<Category>> CreateCategory(Category category);
        Task<ActionResult<Category>> UpdateCategory(int category_id,Category category);
        Task<Category> DeleteCategory(int category_id);

    }
}
