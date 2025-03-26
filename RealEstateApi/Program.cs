
using RealEstateApi.Hubs;
using RealEstateApi.Models.DapperContext;
using RealEstateApi.Repositories.AppUserRepositories;
using RealEstateApi.Repositories.BottomGridRepositories;
using RealEstateApi.Repositories.BottomGridRepository;
using RealEstateApi.Repositories.CategoryRepository;
using RealEstateApi.Repositories.ContactRepositories;
using RealEstateApi.Repositories.EmployeeRepositories;
using RealEstateApi.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstateApi.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstateApi.Repositories.MessageRepositories;
using RealEstateApi.Repositories.PopularLocationRepositories;
using RealEstateApi.Repositories.ProductImageRepositories;
using RealEstateApi.Repositories.ProductRepository;
using RealEstateApi.Repositories.PropertyAmenityRepositories;
using RealEstateApi.Repositories.ServiceRepository;
using RealEstateApi.Repositories.StatisticsRepositories;
using RealEstateApi.Repositories.TestimonialRepositories;
using RealEstateApi.Repositories.ToDoListRepositories;
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
            builder.Services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            builder.Services.AddTransient<IContactRepository, ContactRepository>();
            builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
            builder.Services.AddTransient<IChartRepository, ChartRepository>();
            builder.Services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            builder.Services.AddTransient<IMessageRepository, MessageRepository>();
            builder.Services.AddTransient<IAppUserRepository, AppUserRepository>();
            builder.Services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();



			builder.Services.AddCors(opt =>
			{
				opt.AddPolicy("CorsPolicy", builder =>
				{
					builder.AllowAnyHeader()
					.AllowAnyMethod()
					.SetIsOriginAllowed((host) => true)
					.AllowCredentials();
				});
			});

			builder.Services.AddHttpClient();
			builder.Services.AddSignalR();


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

			app.UseCors("CorsPolicy");

			app.UseHttpsRedirection();

            app.UseAuthorization();


			app.MapControllers();
			app.MapHub<SignalRHub>("/signalrhub");

			app.Run();
        }
    }
}
