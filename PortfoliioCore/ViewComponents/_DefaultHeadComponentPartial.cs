using Microsoft.AspNetCore.Mvc;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
