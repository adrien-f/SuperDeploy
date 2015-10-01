using Microsoft.AspNet.Mvc;

namespace SuperDeploy.Controllers
{
    [Route("Admin/Applications")]
    public class AdminApplicationsController : BaseController
    {
        [HttpGet]
        [Route("New")]
        public IActionResult New()
        {
            return View();
        }
    }
}