using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppp.Models;

namespace WebAppp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
       

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contactus(string email, string subject, string message)
        {
            return Json(email + subject + message);
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
