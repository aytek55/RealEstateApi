using RealEstateApi.Dtos.EmployeeDtos;

namespace RealEstateApi.Repositories.EmployeeRepositories
{
	public interface IEmployeeRepository
	{
		Task<List<ResultEmployeeDto>> GetAllEmployee();
		Task CreateEmployee(CreateEmployeeDto createEmployeeDto);
		Task DeleteEmployee(int id);
		Task UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
		Task<GetByIDEmployeeDto> GetEmployee(int id);
	}
}
