using Assign1.Areas.User.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assign1.Areas.User.Controllers
{
    public class LoginUserController : Controller
    {
        [Area("User")]
        [Route("User/[Controller]/[Action]")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OnLogin(LoginUserModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("DashboardUser", "DashboardUser", new { area = "User" });
            }
            return RedirectToAction("Login", "LoginUser", new { area = "User" });
        }
    }
}
