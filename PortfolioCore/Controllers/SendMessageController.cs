using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        [HttpPost]
        public IActionResult SendMessages(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            ViewBag.success = "Gönderim İşlemi Başarılı!";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
