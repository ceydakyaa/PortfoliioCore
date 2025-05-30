using Microsoft.AspNetCore.Mvc;

namespace PortfoliioCore.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
