using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class EducationController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult EducationList()
        {
            var value=context.Educations.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            var values=context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult DeleteEducation(int id)
        {
            var values=context.Educations.Find(id);
            context.Educations.Remove(values);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = context.Educations.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            var values=context.Educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
