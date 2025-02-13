﻿using Dapper;
using RealEstateApi.Dtos.BottomGridDtos;
using RealEstateApi.Models.DapperContext;
using RealEstateApi.Repositories.BottomGridRepository;

namespace RealEstateApi.Repositories.BottomGridRepositories
{
	public class BottomGridRepository : IBottomGridRepository
	{
		private readonly Context _context;
		public BottomGridRepository(Context context)
		{
			_context = context;
		}
		public async Task CreateBottomGrid(CreateBottomGridDto createBattomGridDto)
		{
			string query = "insert into BottomGrid (Icon,Title,Description) values(@icon,@title,@description)";
			var parameters = new DynamicParameters();
			parameters.Add("@icon", createBattomGridDto.Icon);
			parameters.Add("@title", createBattomGridDto.Title);
			parameters.Add("@description", createBattomGridDto.Description);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task DeleteBottomGrid(int id)
		{
			string query = "Delete From BottomGrid Where BottomGridID=@bottomGridID";
			var parameters = new DynamicParameters();
			parameters.Add("@bottomGridID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
		{
			string query = "Select * From BottomGrid";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultBottomGridDto>(query);
				return values.ToList();
			}
		}

		public async Task<GetBottomGridDto> GetBottomGrid(int id)
		{
			string query = "Select * From BottomGrid Where BottomGridID=@bottomGridID";
			var parameters = new DynamicParameters();
			parameters.Add("@bottomGridID", id);
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
				return values;
			}
		}

		public async Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
		{
			string queary = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description where BottomGridID=@bottomGridID";
			var parameters = new DynamicParameters();
			parameters.Add("@icon", updateBottomGridDto.Icon);
			parameters.Add("@title", updateBottomGridDto.Title);
			parameters.Add("@description", updateBottomGridDto.Description);
			parameters.Add("@bottomGridID", updateBottomGridDto.BottomGridID);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(queary, parameters);
			}
		}
	}
}
