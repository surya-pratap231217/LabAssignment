using Microsoft.AspNetCore.Mvc;

namespace Assign1.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[Controller]/[Action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
