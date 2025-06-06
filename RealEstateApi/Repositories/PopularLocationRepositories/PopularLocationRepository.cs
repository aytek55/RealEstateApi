﻿using Dapper;
using RealEstateApi.Dtos.PopularLocationDtos;
using RealEstateApi.Models.DapperContext;

namespace RealEstateApi.Repositories.PopularLocationRepositories
{
	public class PopularLocationRepository : IPopularLocationRepository
	{
		private readonly Context _context;
		public PopularLocationRepository(Context context)
		{
			_context = context;
		}

		public async Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
		{
			string query = "insert into PopularLocation (CityName,ImageUrl) values(@cityName,@imageUrl)";
			var parameters = new DynamicParameters();
			parameters.Add("@cityName", createPopularLocationDto.CityName);
			parameters.Add("@imageUrl", createPopularLocationDto.ImageUrl);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task DeletePopularLocation(int id)
		{
			string query = "Delete From PopularLocation Where LocationID=@locationID";
			var parameters = new DynamicParameters();
			parameters.Add("@locationID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
		{
			string query = "Select * From PopularLocation";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
				return values.ToList();
			}
		}

		public async Task<GetByIDPopularLocationDto> GetPopularLocation(int id)
		{
			string query = "Select * From PopularLocation Where LocationID=@locationID";
			var parameters = new DynamicParameters();
			parameters.Add("@locationID", id);
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetByIDPopularLocationDto>(query, parameters);
				return values;
			}
		}

		public async Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
		{
			string queary = "Update PopularLocation Set CityName=@cityName,ImageUrl=@imageUrl where LocationID=@locationID";
			var parameters = new DynamicParameters();
			parameters.Add("@cityName", updatePopularLocationDto.CityName);
			parameters.Add("@imageUrl", updatePopularLocationDto.ImageUrl);
			parameters.Add("@locationID", updatePopularLocationDto.LocationID);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(queary, parameters);
			}
		}
	}
}
