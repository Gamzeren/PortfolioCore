using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult AboutList()
        {
            var values=context.abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            var values=context.abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public IActionResult DeleteAbout(int id)
        {
            var value=context.abouts.Find(id);
            context.abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = context.abouts.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            var values=context.abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
