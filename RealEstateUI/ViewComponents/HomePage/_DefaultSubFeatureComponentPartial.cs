﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateUI.Dtos.SubFeatureDtos;

namespace RealEstateUI.ViewComponents.HomePage
{
	public class _DefaultSubFeatureComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _DefaultSubFeatureComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7197/api/SubFeatures");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSubFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
