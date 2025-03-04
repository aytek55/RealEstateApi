using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;

namespace RealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController : ControllerBase
    {
        private readonly ILast5ProductsRepository _lastProductRepository;
        public EstateAgentLastProductsController(ILast5ProductsRepository lastProductRepository)
        {
            _lastProductRepository = lastProductRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLast5ProductAsync(int id)
        {
            var values = await _lastProductRepository.GetLast5ProductAsync(id);
            return Ok(values);
        }
    }
}
