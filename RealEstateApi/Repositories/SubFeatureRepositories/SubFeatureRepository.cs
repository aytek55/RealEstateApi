using Dapper;
using RealEstateApi.Dtos.SubFeatureDtos;
using RealEstateApi.Models.DapperContext;

namespace RealEstateApi.Repositories.SubFeatureRepositories
{
    public class SubFeatureRepository : ISubFeatureRepository
    {
        private readonly Context _context;
        public SubFeatureRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync()
        {
            string query = "Select * From SubFeature";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultSubFeatureDto>(query);
                return values.ToList();
            }
        }
    }
}
