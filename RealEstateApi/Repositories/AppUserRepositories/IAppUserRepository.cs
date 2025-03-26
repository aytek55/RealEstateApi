using RealEstateApi.Dtos.AppUserDtos;

namespace RealEstateApi.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);
    }
}
