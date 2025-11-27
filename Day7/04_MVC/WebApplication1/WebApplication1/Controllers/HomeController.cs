using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //http://localhost/home/index
        public IActionResult Index()
        {
            ViewData["Message"] = $"現在是:{DateTime.Now.ToString("HH:mm:ss")}!";
            ViewBag.Name = "John";
            ViewBag.Age = 30;
            //TempData["TempMessage"] = "這是一條臨時消息!";
            return View();
        }
        public IActionResult Test()
        {

            return View();
        }
        public IActionResult Privacy()
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
