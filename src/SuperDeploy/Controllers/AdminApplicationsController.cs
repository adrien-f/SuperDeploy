using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using SuperDeploy.Supervisor;
using System;
using SuperDeploy.Models;
using SuperDeploy.ViewModels;
using SuperDeploy.DAL;
using System.Threading;
using System.Threading.Tasks;

namespace SuperDeploy.Controllers
{
    [Route("Admin/Applications")]
    public class AdminApplicationsController : BaseController
    {
        private readonly SupervisorClient _supervisor;
        private readonly IApplicationRepository _applicationRepository;
        
        public AdminApplicationsController(SupervisorClient supervisor, IApplicationRepository applicationRepository)
        {
            _supervisor = supervisor;
            _applicationRepository = applicationRepository;
        }

        [HttpGet]
        [Route("New")]
        public IActionResult New()
        {
            var vm = new NewApplicationViewModel { Processes = new List<Process>(_supervisor.Api.GetAllProcesses()) };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("New")]
        public async Task<IActionResult> NewApplication(NewApplicationViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }
            var application = new Application {
                Id = Guid.NewGuid(),
                Name = model.Name,
                SupervisorId = model.SelectedProcess
            };
            await _applicationRepository.NewApplication(application);
            Success($"Application {application.Name} added.");
            return RedirectToAction("Index", "Admin");
        }
    }
}