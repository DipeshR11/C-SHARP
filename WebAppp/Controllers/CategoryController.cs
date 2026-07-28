using Microsoft.AspNetCore.Mvc;
using WebAppp.Models;

namespace WebAppp.Controllers
{
    public class CategoryController : Controller
    {
        static List<Category> categories = new List<Category>();

        public IActionResult Index()
        {
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                categories.Add(category);
                return RedirectToAction("Index");
            }

            return View(category);
        }

        public IActionResult Detail(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
    }
}
