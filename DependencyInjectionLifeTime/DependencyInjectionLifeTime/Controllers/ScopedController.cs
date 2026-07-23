using DependencyInjectionLifeTime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionLifeTime.Controllers
{
    public class ScopedController : Controller
    {
        private readonly IScopedService _Service1;
        private readonly IScopedService _Service2;

        public ScopedController(IScopedService Service1, IScopedService Service2)
        {
            _Service1 = Service1;
            _Service2 = Service2;
        }
        public IActionResult Index()
        {
            ViewBag.Id1 = _Service1.GetId();
            ViewBag.Id2 = _Service2.GetId();
            return View();
        }
    }
}
