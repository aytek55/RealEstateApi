using Dapper;
using RealEstateApi.Dtos.ProductDtos;
using RealEstateApi.Models.DapperContext;

namespace RealEstateApi.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        //public async Task CreateProduct(CreateProductDto createProductDto)
        //{
        //    string query = "insert into Product (Title,Price,City,District,CoverImage,Address,Description,ProductType,DealOfTheDay,AdvertisementDate," +
        //        "ProductStatus,ProductCategory,EmployeeID) values(@title,@price,@city,@district,@coverImage,@address,@description,@productType,@dealOfTheDay," +
        //        "@advertisementDate,@productStatus,@productCategory,@employeeID)";
        //    var parameters = new DynamicParameters();
        //    parameters.Add("@title", createProductDto.Title);
        //    parameters.Add("@price", createProductDto.Price);
        //    parameters.Add("@city", createProductDto.City);
        //    parameters.Add("@district", createProductDto.District);
        //    parameters.Add("@coverImage", createProductDto.CoverImage);
        //    parameters.Add("@address", createProductDto.Address);
        //    parameters.Add("@description", createProductDto.Description);
        //    parameters.Add("@productType", createProductDto.ProductType);
        //    parameters.Add("@dealOfTheDay", createProductDto.DealOfTheDay);
        //    parameters.Add("@advertisementDate", createProductDto.AdvertisementDate);
        //    parameters.Add("@productStatus", createProductDto.ProductStatus);
        //    parameters.Add("@productCategory", createProductDto.ProductCategory);
        //    parameters.Add("@employeeID", createProductDto.EmployeeID);
        //    using (var connection = _context.CreateConnection())
        //    {
        //        await connection.ExecuteAsync(query, parameters);
        //    }
        //}

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "SELECT ProductID,Title,Price,City,District,CategoryName FROM Product " +
                "INNER JOIN Category ON Product.ProductCategory = Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        
    }
}
