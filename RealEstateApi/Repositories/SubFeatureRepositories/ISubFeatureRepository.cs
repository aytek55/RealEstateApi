using RealEstateApi.Dtos.SubFeatureDtos;

namespace RealEstateApi.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}
