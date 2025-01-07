using RealEstateApi.Dtos.CategoryDtos;

namespace RealEstateApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategory(CreateCategoryDto categoryDto);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);
    }
}
