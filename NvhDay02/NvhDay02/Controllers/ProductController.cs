using Microsoft.AspNetCore.Mvc;

namespace NvhDay02.Controllers
{
    public class ProductController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllProducts()
        {
            List<Models.Product> products = new List<Models.Product>
            {
                new Models.Product { Id = 1, Name = "Product A", Price = 10.0m },
                new Models.Product { Id = 2, Name = "Product B", Price = 20.0m },
                new Models.Product { Id = 3, Name = "Product C", Price = 30.0m }
            };
            ViewBag.products = products;
            // trả về view có tên là Products trong thư mục Views/Product
            return View("Products");
        }
       public IActionResult GetProduct()
        {
            Models.Product p = new Models.Product
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
