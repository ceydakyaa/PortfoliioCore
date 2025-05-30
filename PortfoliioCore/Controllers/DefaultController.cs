using Microsoft.AspNetCore.Mvc;

namespace PortfoliioCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
