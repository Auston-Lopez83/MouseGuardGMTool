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

        public IActionResult TheGuard()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult TheTerritories()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

		public IActionResult TheMissions()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Recruitment()
		{
			ViewData["Message"] = "Your contact page.";

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
