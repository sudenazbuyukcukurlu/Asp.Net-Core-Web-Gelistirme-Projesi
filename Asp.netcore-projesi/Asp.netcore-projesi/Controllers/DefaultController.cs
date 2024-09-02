using Microsoft.AspNetCore.Mvc;

namespace Asp.netcore_projesi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
