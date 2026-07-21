using Microsoft.AspNetCore.Mvc;

namespace DataPassingInDotNetCore.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
