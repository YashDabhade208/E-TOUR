using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly Appdbcontext context;

        public SubCategoryService(Appdbcontext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<SubCategory>> CreateSubCatgory(SubCategory subcategory)
        {
            context.SubCategories.Add(subcategory);
            await context.SaveChangesAsync();
            return subcategory;
        }

        public async Task<SubCategory> DeleteSubCategory(int subcategory_id)
        {
            SubCategory subcategory = context.SubCategories.Find(subcategory_id);
            if (subcategory != null)
            {
                context.SubCategories.Remove(subcategory);
                await context.SaveChangesAsync();
            }
            return subcategory;
        }

        public async Task<ActionResult<IEnumerable<SubCategory>>> GetAllSubCategories()
        {
            return await context.SubCategories.ToListAsync();
        }

        public async Task<ActionResult<SubCategory>?> GetSubCategoryById(int id)
        {
            if (context.SubCategories == null)
            {
                return null;
            }
            var subcategory = await context.SubCategories.FindAsync(id);
            if (subcategory == null)
            {
                return null;
            }
            return subcategory;
        }

        public async Task<ActionResult<SubCategory>> UpdateSubCategory(int subcategory_id, SubCategory subcategory)
        {
            if (subcategory_id != subcategory.Subcategory_Id)
            {
                return null;
            }

            context.Entry(subcategory).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch
            {
                Console.WriteLine("Not Updated");
            }

            return subcategory;
        }
    }
}
