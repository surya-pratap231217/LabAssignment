using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using test.Models;
namespace test.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                //To Do:
                TempData["Message"] = "Your account has been created!";
                //TempData["Name"] = model.Name;

                //string strData = JsonSerializer.Serialize(model);
                //
                return RedirectToAction("Message");
            }
            return View();
        }

        public IActionResult Message()
        {
            //string message = (string)TempData["Message"]; //read once
            //string name = (string)TempData.Peek("Name"); //read many


            return View();
        }
    }
}