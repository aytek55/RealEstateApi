﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.ViewComponents.HomePage
{
	public class _DefaultOurClientsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
