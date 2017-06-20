using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MouseGuardGMTool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Local()
        {
            ViewData["Message"] = "Local";

            return View(); 
        }

        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult TheTerritories()
        {
            ViewData["Message"] = "The Territories";

            return View();
        }

		public IActionResult TheMissions()
		{
			ViewData["Message"] = "The Missions";

			return View();
		}

		public IActionResult Recruitment()
		{
			ViewData["Message"] = "Recruitment";

			return View();
		}

        public IActionResult TheDenizens()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
