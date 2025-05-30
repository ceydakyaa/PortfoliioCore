using Microsoft.AspNetCore.Mvc;
using PortfoliioCore.Context;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.MyWorks.ToList();
            return View(values);
        }
    }
}
