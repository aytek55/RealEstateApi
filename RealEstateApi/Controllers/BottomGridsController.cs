﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Dtos.BottomGridDtos;
using RealEstateApi.Repositories.BottomGridRepository;

namespace RealEstateApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BottomGridsController : ControllerBase
	{
		private readonly IBottomGridRepository _bottomGridRepository;

		public BottomGridsController(IBottomGridRepository bottomGridRepository)
		{
			_bottomGridRepository = bottomGridRepository;
		}
		[HttpGet]
		public async Task<IActionResult> BottomGridList()
		{
			var values = await _bottomGridRepository.GetAllBottomGridAsync();
			return Ok(values);
		}
		[HttpPost]
		public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
		{
			_bottomGridRepository.CreateBottomGrid(createBottomGridDto);
			return Ok("Veri Başarılı Bir Şekilde Eklendi");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBottomGrid(int id)
		{
			_bottomGridRepository.DeleteBottomGrid(id);
			return Ok("Veri Başarılı Bir Şekilde Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
		{
			_bottomGridRepository.UpdateBottomGrid(updateBottomGridDto);
			return Ok("Veri Başarıyla Güncellendi");
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetBottomGrid(int id)
		{
			var values = await _bottomGridRepository.GetBottomGrid(id);
			return Ok(values);
		}
	}
}
