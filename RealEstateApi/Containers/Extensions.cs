using RealEstateApi.Repositories.AppUserRepositories;
using RealEstateApi.Repositories.BottomGridRepositories;
using RealEstateApi.Repositories;
using RealEstateApi.Repositories.CategoryRepository;
using RealEstateApi.Repositories.ContactRepositories;
using RealEstateApi.Repositories.EmployeeRepositories;
using RealEstateApi.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstateApi.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstateApi.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstateApi.Repositories.MessageRepositories;
using RealEstateApi.Repositories.PopularLocationRepositories;
using RealEstateApi.Repositories.ProductImageRepositories;
using RealEstateApi.Repositories.ProductRepository;
using RealEstateApi.Repositories.PropertyAmenityRepositories;
using RealEstateApi.Repositories.ServiceRepository;
using RealEstateApi.Repositories.StatisticsRepositories;
using RealEstateApi.Repositories.SubFeatureRepositories;
using RealEstateApi.Repositories.TestimonialRepositories;
using RealEstateApi.Repositories.ToDoListRepositories;
using RealEstateApi.Repositories.WhoWeAreRepository;
using RealEstateApi.Models.DapperContext;
using RealEstateApi.Repositories.BottomGridRepository;

namespace RealEstateApi.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<ILoginRepo, LoginRepo>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
