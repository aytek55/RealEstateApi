﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateUI.Dtos.EmployeeDtos;
using System.Text;

namespace RealEstateUI.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		//private readonly ILoginService _loginService;
		public EmployeeController(IHttpClientFactory httpClientFactory,/* ILoginService loginService,*/ IHttpContextAccessor contextAccessor)
		{
			_httpClientFactory = httpClientFactory;
			//_loginService = loginService;
		}
		public async Task<IActionResult> Index()
		{
			var user = User.Claims;
			var userId = 1; //_loginService.GetUserId;


			var token = User.Claims.FirstOrDefault(x => x.Type == "realestatetoken")?.Value;
			if (token != null)
			{
				var client = _httpClientFactory.CreateClient();
				var responseMessage = await client.GetAsync("https://localhost:7197/api/Employees");
				if (responseMessage.IsSuccessStatusCode)
				{
					var jsonData = await responseMessage.Content.ReadAsStringAsync();
					var values = JsonConvert.DeserializeObject<List<ResultEmployeeDto>>(jsonData);
					return View(values);
				}
			}
			return View();
		}
		[HttpGet]
		public IActionResult CreateEmployee()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createEmployeeDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7197/api/Employees", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> DeleteEmployee(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var reponseMessage = await client.DeleteAsync($"https://localhost:7197/api/Employees/{id}");
			if (reponseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateEmployee(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7197/api/Employees/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateEmployeeDto>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateEmployeeDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7197/api/Employees/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
