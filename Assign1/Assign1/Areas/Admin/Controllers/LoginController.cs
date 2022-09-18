using Microsoft.AspNetCore.Mvc;
using Assign1.Areas.Admin.Models;

namespace Assign1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[Controller]/[Action]")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnLogin(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard", "Dashboard", new { area = "Admin" });
            }
            return RedirectToAction("Login", "Login", new { area = "Admin" });
        }
    }
}
