using DependencyInjectionLifeTime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionLifeTime.Controllers
{
    public class TransientController : Controller
    {
        private readonly ITransientService _Service1;
        private readonly ITransientService _Service2;

        public TransientController(ITransientService Service1, ITransientService Service2)
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
