using DataPassingInDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DataPassingInDotNetCore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.username == "user@gmail.com" && model.password == "134567")
                {
                    TempData["Message"] = "Welcome back";

                    string strUser = JsonSerializer.Serialize(model);
                    HttpContext.Session.SetString("User", strUser);

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ViewBag.ErrorMessage = "Username or password doesn't exist!";
                }
                
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
