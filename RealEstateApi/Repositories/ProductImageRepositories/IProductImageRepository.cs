using RealEstateApi.Dtos.ProductDetailDtos;
using RealEstateApi.Dtos.ProductImageDtos;

namespace RealEstateApi.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);
    }
}
