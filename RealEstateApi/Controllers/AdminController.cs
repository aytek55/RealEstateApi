using Microsoft.AspNetCore.Mvc;

namespace RealEstateApi.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
