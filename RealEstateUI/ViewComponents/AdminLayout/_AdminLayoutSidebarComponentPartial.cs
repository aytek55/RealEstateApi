﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.ViewComponents.AdminLayout
{
	public class _AdminLayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
