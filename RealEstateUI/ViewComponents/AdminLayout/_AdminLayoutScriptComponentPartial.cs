using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.ViewComponents.AdminLayout
{
	public class _AdminLayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
