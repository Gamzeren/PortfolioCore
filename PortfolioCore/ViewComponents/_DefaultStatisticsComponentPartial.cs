using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=context.Testimonials.Count();
            ViewBag.v2=context.portfolios.Count();
            ViewBag.v3=context.skills.Count();
            Random random= new Random();
            int randomNumber = random.Next(10, 21);
            ViewBag.v4 = randomNumber;
            return View();
        }
    }
}
