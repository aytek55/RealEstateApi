﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RealEstateUI.Dtos.PopularLocationDtos;
using RealEstateUI.Models;

namespace RealEstateUI.ViewComponents.HomePage
{
	public class _DefaultProductListExploreCitiesComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly ApiSettings _apiSettings;
		public _DefaultProductListExploreCitiesComponentPartial(IHttpClientFactory httpClientFactory, IOptions<ApiSettings> apiSettings)
		{
			_httpClientFactory = httpClientFactory;
			_apiSettings = apiSettings.Value;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			client.BaseAddress = new Uri(_apiSettings.BaseUrl);
			var responseMessage = await client.GetAsync("PopularLocations");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultPopularLocationDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
