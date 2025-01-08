using RealEstateApi.Dtos.ProductDtos;

namespace RealEstateApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
         Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
         }
}
