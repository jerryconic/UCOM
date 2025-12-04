using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;
using WebDemo.Models;

namespace WebDemo.Controllers
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
            //ViewBag.Data = "Hello John!"; //dynamic
            //ViewData["Data"] = "Hello John!"; //Dictionary[key] =  object
            //ViewBag.Employee = new { Id = "C001", Name = "John" };
            ViewBag.Name = "John";

            List<string> users = new List<string> { "Alice", "Bob", "Charlie" };
            ViewBag.Users = users;

            return View();
        }

        [HttpGet]
        public IActionResult Employee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeResult(int Id, string Name, DateTime Birthdate, int Salary)
        {
            ViewBag.Employee = new { Id = Id, Name = Name, Birthdate = Birthdate, Salary = Salary };            
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeModelResult(EmployeeViewModel model)
        {
            ViewBag.Employee = new { Id = model.Id, Name = model.Name, Birthdate = model.Birthdate, Salary = model.Salary };
            return View();
        }
        [HttpGet]
        public IActionResult EmployeeModel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EmployeeCombine()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeCombine(EmployeeViewModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.EmployeeData = model;
                
            }
            else
            {
                ViewBag.EmployeeData = null;
            }
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
