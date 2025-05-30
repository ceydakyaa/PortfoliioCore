using Microsoft.AspNetCore.Mvc;
using PortfoliioCore.Context;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
