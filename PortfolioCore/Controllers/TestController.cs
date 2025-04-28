using System.ComponentModel.Design.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
