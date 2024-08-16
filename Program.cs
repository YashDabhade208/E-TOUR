using eTour.Repository;
using eTour.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace eTour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);





            builder.Services.AddControllers()
    .AddJsonOptions(opts =>
    {
        opts.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    });














            // Add CORS policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigins",
                    policy =>
                    {
                        policy.WithOrigins("*")
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                    });
            });

            // Add controllers
            builder.Services.AddControllers();

           /* // JWT Authentication setup
            var jwtSettings = builder.Configuration.GetSection("Jwt");
            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);

            object value = builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidIssuer = jwtSettings["Issuer"],
                        ValidAudience = jwtSettings["Audience"]
                    };
                });*/

            // Add your custom services
            builder.Services.AddTransient<ICategoryService, CategoryService>();
            builder.Services.AddTransient<ISubCategoryService, SubCategoryService>();
            builder.Services.AddTransient<IToursService, ToursService>();
            builder.Services.AddTransient<IIterneryService, IterneryService>();
            builder.Services.AddTransient<ITourDateService, TourDateService>();
            builder.Services.AddTransient<ICostService, CostService>();
            builder.Services.AddTransient<ICustomerService, CustomerService>();
            builder.Services.AddTransient<IBookingService, BookingService>();
            builder.Services.AddTransient<IPassengerService, PassengerService>();
            builder.Services.AddTransient<IPaymentService, PaymentService>();

     
            builder.Services.AddDbContext<Appdbcontext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("eTourDBConnection")),
                ServiceLifetime.Transient);

     
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

       
            app.UseCors("AllowSpecificOrigins");

            app.UseAuthentication();

            
            app.UseAuthorization();

            
            app.MapControllers();

            
            app.Run();
        }
    }
}
