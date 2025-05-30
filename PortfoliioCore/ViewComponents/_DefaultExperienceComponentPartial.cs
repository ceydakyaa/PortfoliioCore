using Microsoft.AspNetCore.Mvc;
using PortfoliioCore.Context;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultExperienceComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
