using System;
using Microsoft.AspNetCore.Mvc;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool.Controllers
{
    public class TheGuard : Controller
    {
        private IPlayerRepository repository;
        public TheGuard(IPlayerRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.TheGuards);
    }
}
