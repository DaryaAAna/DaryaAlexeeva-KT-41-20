using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ServiceExtensions
{
    public class ServiceExtensions : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
