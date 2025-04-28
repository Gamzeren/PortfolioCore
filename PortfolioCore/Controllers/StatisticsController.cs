using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "İstatistikler";
            ViewBag.v1=context.skills.Count();
            ViewBag.v2 = context.skills.Sum(x=>x.SkillValue);
            ViewBag.v3 = context.skills.Where(x => x.SkillValue >= 70).Count();
            ViewBag.v4 = context.skills.Average(x => x.SkillValue);
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Experiences.Where(x=>x.SubTitle== "Developer").Count();
            ViewBag.v7=context.Messages.Where(x=>x.IsRead== true).Count();
            ViewBag.v8=context.Messages.Where(x=>x.IsRead== false).Count();
            ViewBag.v9=context.services.Count();
            ViewBag.v10 = context.Testimonials.Where(x => x.Title == "Akademisyen").Count();
            return View();
        }
    }
}
