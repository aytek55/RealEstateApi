using RealEstateApi.Dtos.PopularLocationDtos;

namespace RealEstateApi.Repositories.PopularLocationRepositories
{
	public interface IPopularLocationRepository
	{
		Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
		Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
		Task DeletePopularLocation(int id);
		Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
		Task<GetByIDPopularLocationDto> GetPopularLocation(int id);
	}
}
