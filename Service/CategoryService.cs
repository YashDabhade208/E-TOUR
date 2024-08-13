using eTour.Model;
using eTour.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTour.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly Appdbcontext context;

        public CategoryService(Appdbcontext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            context.Categories.Add(category);
            await context.SaveChangesAsync();
            return category;
        }

        public async Task<Category>DeleteCategory(int category_id)
        {
           Category category=context.Categories.Find(category_id);  
            if (category != null) 
            {
                context.Categories.Remove(category);
                await context.SaveChangesAsync();
            }
            return category;
        }

        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategory()
        {
           if(context.Categories == null)
            {
                return null;
            }
           return await context.Categories.ToListAsync();
        }

        public async Task<ActionResult<Category>?> GetCategoryById(int id)
        {
            if(context.Categories==null)
            {
                return null;
            }
            var category = await context.Categories.FindAsync(id);
            if(category==null)
            {
                return null;
            }
            return category;
        }

        public async Task<ActionResult<Category>> UpdateCategory(int category_id, Category category)
        {
            if(category_id != category.Category_Id)
            {
                return null;
            }

            context.Entry(category).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch 
            {
                Console.WriteLine("Not Updated"); 
            }

            return category;
        }
    }
}
