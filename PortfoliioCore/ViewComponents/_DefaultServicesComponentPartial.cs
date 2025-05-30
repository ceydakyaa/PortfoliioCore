using Microsoft.AspNetCore.Mvc;
using PortfoliioCore.Context;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultServicesComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var services = context.Services.OrderByDescending(x => x.ServiceId).Take(6).ToList();
            return View(services);
        }
    }
}
