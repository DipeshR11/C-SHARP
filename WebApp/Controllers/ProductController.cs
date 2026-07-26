using Microsoft.AspNetCore.Mvc;
using webproject.Models;
namespace webproject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            return View("Detail", product);
        }
        public IActionResult Save()
        {
            return View();
        }
    }
}