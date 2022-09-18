using Microsoft.AspNetCore.Mvc;

namespace Assign1.Areas.User.Controllers
{
    public class DashboardUserController : Controller
    {
        [Area("User")]
        [Route("User/[Controller]/[Action]")]
        public IActionResult DashboardUser()
        {
            return View();
        }
    }
}
