using System;
using Microsoft.AspNetCore.Mvc;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool.Controllers
{
    public class TheGuard : Controller
    {
        private ITheGuardRepository repository;
        public TheGuard(ITheGuardRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.TheGuards);
    }
}
