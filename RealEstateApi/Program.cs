
using RealEstateApi.Models.DapperContext;
using RealEstateApi.Repositories.BottomGridRepositories;
using RealEstateApi.Repositories.BottomGridRepository;
using RealEstateApi.Repositories.CategoryRepository;
using RealEstateApi.Repositories.EmployeeRepositories;
using RealEstateApi.Repositories.PopularLocationRepositories;
using RealEstateApi.Repositories.ProductRepository;
using RealEstateApi.Repositories.ServiceRepository;
using RealEstateApi.Repositories.TestimonialRepositories;
using RealEstateApi.Repositories.WhoWeAreRepository;

namespace RealEstateApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddTransient<Context>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
            builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
