using System;
using Microsoft.AspNetCore.Mvc;
namespace MouseGuardGMTool.Controllers
{
    public class RecruitmentController : Controller
    {
        private IPlayerRepository repository;
        public RecruitmentController(IPlayerRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Recruitments);
    }
}
