using CW9_1_V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CW9_1_V2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View(DAL.ProductRepository.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            DAL.ProductRepository.Products.Add(product);
            return RedirectToAction(nameof(this.List));
        }

    }
}
