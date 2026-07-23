using DependencyInjectionLifeTime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionLifeTime.Controllers
{
    public class SingletonController : Controller
    {
        private readonly ISingletonService _Service1;
        private readonly ISingletonService _Service2;

        public SingletonController(ISingletonService Service1, ISingletonService Service2)
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
