﻿using Dapper;
using RealEstateApi.Dtos.TestimonialDtos;
using RealEstateApi.Models.DapperContext;

namespace RealEstateApi.Repositories.TestimonialRepositories
{
	public class TestimonialRepository : ITestimonialRepository
	{
		private readonly Context _context;
		public TestimonialRepository(Context context)
		{
			_context = context;
		}
		public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
		{
			string query = "Select * From Testimonial";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultTestimonialDto>(query);
				return values.ToList();
			}
		}
	}
}
