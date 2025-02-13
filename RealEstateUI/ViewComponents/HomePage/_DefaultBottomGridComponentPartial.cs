using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateUI.Dtos.BottomGridDtos;

namespace RealEstateUI.ViewComponents.HomePage
{
	public class _DefaultBottomGridComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public _DefaultBottomGridComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7197/api/BottomGrids");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBottomGridDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
