using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace RealEstateUI.ViewComponents.HomePage
{
	public class _DefaultHomePageProductList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
		//private readonly IHttpClientFactory _httpClientFactory;

		//public _DefaultHomePageProductList(IHttpClientFactory httpClientFactory)
		//{
		//	_httpClientFactory = httpClientFactory;
		//}

		//public async Task<IViewComponentResult> InvokeAsync()
		//{
		//	var client = _httpClientFactory.CreateClient();
		//	var responseMessage = await client.GetAsync("https://localhost:44331/api/Products/GetProductByDealOfTheDayTrueWithCategory");
		//	if (responseMessage.IsSuccessStatusCode)
		//	{
		//		var jsonData = await responseMessage.Content.ReadAsStringAsync();
		//		var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
		//		return View(values);
		//	}
		//	return View();
		//}
	}
}
