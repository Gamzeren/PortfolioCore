using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult ContactList()
        {
            var values=context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        public IActionResult DeleteContact(int id)
        {
            var values = context.Contacts.Find(id);
            context.Contacts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values=context.Contacts.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
    
}
