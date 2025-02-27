using RealEstateApi.Dtos.ContactDtos;

namespace RealEstateApi.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        Task CreateContact(CreateContactDto createContactDto);
        Task DeleteContact(int id);
        Task<GetByIDContactDto> GetContact(int id);
    }
}
