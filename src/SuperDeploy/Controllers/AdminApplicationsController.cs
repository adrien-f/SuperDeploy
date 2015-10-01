using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using SuperDeploy.Supervisor;
using SuperDeploy.ViewModels;

namespace SuperDeploy.Controllers
{
    [Route("Admin/Applications")]
    public class AdminApplicationsController : BaseController
    {
        private readonly SupervisorClient _supervisor;

        public AdminApplicationsController(SupervisorClient supervisor)
        {
            _supervisor = supervisor;
        }

        [HttpGet]
        [Route("New")]
        public IActionResult New()
        {
            var vm = new NewApplicationViewModel {Processes = new List<Process>(_supervisor.Api.GetAllProcesses())};
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("New")]
        public IActionResult NewApplication(NewApplicationViewModel model)
        {
            return View(model);
        }
    }
}