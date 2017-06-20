using System;
using Microsoft.AspNetCore.Mvc;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool.Controllers
{
    public class TheMission : Controller
    {
        private IMissionRepository repository;
        public TheMission(IMissionRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.TheMissions);
    }
}
