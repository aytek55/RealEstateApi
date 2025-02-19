using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
