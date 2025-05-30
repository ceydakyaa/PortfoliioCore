using Microsoft.AspNetCore.Mvc;
using PortfoliioCore.Context;
using PortfoliioCore.Entities;

namespace PortfoliioCore.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();

        }
        [HttpPost]
        public IActionResult SendMessages(Message message)
        {
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            TempData["Success"] = "Mesajınız Başarıyla İletildi";
            return RedirectToAction("Index", "Default");
        }

    }
}
