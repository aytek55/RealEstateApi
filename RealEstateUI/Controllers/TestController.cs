using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
