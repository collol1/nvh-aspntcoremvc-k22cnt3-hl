using Microsoft.AspNetCore.Mvc;

namespace NvhDay02.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
