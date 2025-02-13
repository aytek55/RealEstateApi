using RealEstateApi.Dtos.TestimonialDtos;

namespace RealEstateApi.Repositories.TestimonialRepositories
{
	public interface ITestimonialRepository
	{
		Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
	}
}
