﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Dtos.WhoWeAreDtos;
using RealEstateApi.Repositories.WhoWeAreRepository;
using System.Text;

namespace RealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreDetailRepository;
        public WhoWeAreDetailController(IWhoWeAreDetailRepository whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRepository.GetAllWhoWeAreDetail();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            await _whoWeAreDetailRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDto);
            return Ok("Hakkımızda Kısmı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            await _whoWeAreDetailRepository.DeleteWhoWeAreDetail(id);
            return Ok("Hakkımızda Kısmı Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            await _whoWeAreDetailRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDto);
            return Ok("Hakkımızda Kısmı Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _whoWeAreDetailRepository.GetWhoWeAreDetail(id);
            return Ok(value);
        }
    }
}
