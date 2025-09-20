using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Nvhlession03View.Models;

namespace Nvhlession03View.Controllers
{
    public class NvhHomeController : Controller
    {
        private readonly ILogger<NvhHomeController> _logger;

        public NvhHomeController(ILogger<NvhHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NvhIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NvhAbout()
        {
            return View();
        }

        public IActionResult NvhViewIf()
        {
            return View();
        }
        public IActionResult NvhViewLoop()
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