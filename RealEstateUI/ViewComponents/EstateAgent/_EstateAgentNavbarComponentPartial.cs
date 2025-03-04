using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.ViewComponents.EstateAgent
{
    public class _EstateAgentNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
