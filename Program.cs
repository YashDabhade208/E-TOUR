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

      
                builder.Services.AddControllers();








                builder.Services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                    };

                });




        
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
                builder.Services.AddTransient<ITourDetailsService, TourDetailsService>();


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
