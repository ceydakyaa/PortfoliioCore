using Microsoft.AspNetCore.Mvc;
using PortfoliioCore.Context;

namespace PortfoliioCore.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}
