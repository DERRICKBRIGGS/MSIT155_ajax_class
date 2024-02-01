using ajax_class.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ajax_class.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult jsonli()
        {
            return View();
        }
        public IActionResult resultquery()
        {
            return View();
        }
        public IActionResult first()
        {
            return View();
        }
        public IActionResult returncontain()
        {
            return View();
        }
        public IActionResult addressSelect()
        {
            return View();
        }
        public IActionResult addApiimage()
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
