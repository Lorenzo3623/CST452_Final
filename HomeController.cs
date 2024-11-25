using ButtonGrind.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ButtonGrind.Controllers
{
    // This controller handles actions related to the home page
    public class HomeController : Controller
    {
        // Logger instance for logging information and errors
        private readonly ILogger<HomeController> _logger;

        // Constructor to initialize the logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action to display the home page
        public IActionResult Index()
        {
            return View();
        }

        // Action to display the privacy policy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Action to display the registration page
        public ActionResult Reg()
        {
            return View();
        }

        // Action to handle and display error pages
        // It uses the current request ID for tracing errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
