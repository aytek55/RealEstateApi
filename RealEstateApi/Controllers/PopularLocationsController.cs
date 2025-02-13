﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Dtos.PopularLocationDtos;
using RealEstateApi.Repositories.PopularLocationRepositories;

namespace RealEstateApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PopularLocationsController : ControllerBase
	{
		private readonly IPopularLocationRepository _locationRepository;

		public PopularLocationsController(IPopularLocationRepository locationRepository)
		{
			_locationRepository = locationRepository;
		}
		[HttpGet]
		public async Task<IActionResult> PopularLocationList()
		{
			var value = await _locationRepository.GetAllPopularLocationAsync();
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
		{
			await _locationRepository.CreatePopularLocation(createPopularLocationDto);
			return Ok("Lokasyon Kısmı Başarılı Bir Şekilde Eklendi");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeletePopularLocation(int id)
		{
			await _locationRepository.DeletePopularLocation(id);
			return Ok("Lokasyon Kısmı Başarılı Bir Şekilde Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
		{
			await _locationRepository.UpdatePopularLocation(updatePopularLocationDto);
			return Ok("Lokasyon Kısmı Başarıyla Güncellendi");
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetPopularLocation(int id)
		{
			var values = await _locationRepository.GetPopularLocation(id);
			return Ok(values);
		}
	}
}
