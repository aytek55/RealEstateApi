﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class LayoutEstateAgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
