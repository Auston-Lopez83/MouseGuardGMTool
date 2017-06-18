using System;
using Microsoft.AspNetCore.Mvc;
namespace MouseGuardGMTool.Controllers
{
    public class RecruitmentController : Controller
    {
<<<<<<< HEAD:MouseGuardGMTool/Controllers/TheGuard.cs
        private ITheGuardRepository repository;
        public TheGuard(ITheGuardRepository repo)
=======
        private IPlayerRepository repository;
        public RecruitmentController(IPlayerRepository repo)
>>>>>>> parent of 7858a07... More updates:MouseGuardGMTool/Controllers/RecruitmentController.cs
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Recruitments);
    }
}
