using Microsoft.AspNetCore.Mvc;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
