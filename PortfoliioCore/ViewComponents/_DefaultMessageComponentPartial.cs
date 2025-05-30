using Microsoft.AspNetCore.Mvc;
using PortfoliioCore.Entities;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultMessageComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new Message());
        }
    }
}
