using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult ServiceList()
        {
            var values= context.services.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            context.services.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        public IActionResult DeleteService(int id)
        {
            var values=context.services.Find(id);
            context.services.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = context.services.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            context.services.Update(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}
