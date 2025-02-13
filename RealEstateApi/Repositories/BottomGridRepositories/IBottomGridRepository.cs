using RealEstateApi.Dtos.BottomGridDtos;

namespace RealEstateApi.Repositories.BottomGridRepository
{
	public interface IBottomGridRepository
	{
		Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
		Task CreateBottomGrid(CreateBottomGridDto createBattomGridDto);
		Task DeleteBottomGrid(int id);
		Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
		Task<GetBottomGridDto> GetBottomGrid(int id);
	}
}
