using Microsoft.AspNetCore.Mvc;

namespace Assign1.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[Controller]/[Action]")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
