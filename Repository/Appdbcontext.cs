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
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Tours> Tour { get; set; }
        public DbSet<Iternery> Iterneries { get; set; } 
        public DbSet<TourDate> TourDates { get; set; }
        public DbSet<Cost> Costs { get; set; }

    }
}
