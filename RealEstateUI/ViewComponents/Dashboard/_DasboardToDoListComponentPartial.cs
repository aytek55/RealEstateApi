﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateUI.Dtos.ToDoListDtos;

namespace RealEstateUI.ViewComponents.Dashboard
{
    public class _DasboardToDoListComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DasboardToDoListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7197/api/ToDoLists");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultToDoListDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
