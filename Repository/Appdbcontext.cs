using eTour.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace eTour.Repository
{
    public class Appdbcontext:DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext>options):base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=eTour;Integrated Security=True");
            }
        }

        public DbSet<Category> Categories {  get; set; }
        
    }
}
