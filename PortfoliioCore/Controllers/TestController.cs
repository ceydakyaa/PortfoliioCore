using Microsoft.AspNetCore.Mvc;

namespace PortfoliioCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
