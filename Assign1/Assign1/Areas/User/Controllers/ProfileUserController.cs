using Microsoft.AspNetCore.Mvc;

namespace Assign1.Areas.User.Controllers
{
    public class ProfileUserController : Controller
    {
        [Area("User")]
        [Route("User/[Controller]/[Action]")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
