using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
