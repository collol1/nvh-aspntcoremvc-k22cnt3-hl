using Microsoft.AspNetCore.Mvc;

namespace NvhDay02.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductController : Controller
    {
        public IActionResult GetProduct()
        {
            Product p = new Product
            {
                Id = 1,
                Name = "Product A",
                Price = 10.0m
            };
            ViewBag.products = p;
            ViewData["productsvd"] = p;
            return View();
        }
    }
}
