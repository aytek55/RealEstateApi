using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
