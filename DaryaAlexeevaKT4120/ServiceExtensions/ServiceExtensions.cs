using Microsoft.AspNetCore.Mvc;

namespace DaryaAlexeevaKT4120.ServiceExtensions
{
    public class ServiceExtensions : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
