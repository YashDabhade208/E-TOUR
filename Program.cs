
using eTour.Repository;
using eTour.Service;
using Microsoft.EntityFrameworkCore;

namespace eTour
{
    public class Program
    {
        public static void Main(string[] args)  
        {
            var builder = WebApplication.CreateBuilder(args);

           

            builder.Services.AddControllers();
            builder.Services.AddTransient<ICategoryService, CategoryService>();
            builder.Services.AddTransient<ISubCategoryService, SubCategoryService>();
            builder.Services.AddTransient<IToursService, ToursService>();
            builder.Services.AddTransient<IIterneryService, IterneryService>();
            //builder.Services.AddTransient<ITourDateService, TourDateService>();
            builder.Services.AddDbContext<Appdbcontext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("eTourDBConnection")), ServiceLifetime.Transient);



















            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
