using Microsoft.AspNetCore.Mvc;
using WebAppp.Models;

namespace WebAppp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "HP Laptop with Intel Core i5 processor",
                    Price = 800
                },
                new Product
                {
                    Id = 2,
                    Name = "Mobile Phone",
                    Description = "Android Smartphone",
                    Price = 500
                }
            };

            return View(products);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            return View("Details", product);
        }

        public IActionResult Details(int id)
        {
            var product = new Product
            {
                Id = id,
                Name = "Sample Product",
                Description = "Sample Description",
                Price = 1000
            };

            return View(product);
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}