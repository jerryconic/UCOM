using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data;
using System.Diagnostics;
using WebDemo.Models;
using Microsoft.Data.SqlClient;
namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env, IConfiguration config)
        {
            _logger = logger;
            _env = env;
            _config = config;
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
            if (ModelState.IsValid)
            {
                ViewBag.EmployeeData = model;
            }
            else
            {
                ViewBag.EmployeeData = null;
            }
            return View();
        }

        public IActionResult EmployeeSave()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeSave(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.EmployeeData = model;

                // 準備輸出路徑與內容
                var uploadsDir = Path.Combine(_env.WebRootPath, "uploads");
                var filePath = Path.Combine(uploadsDir, "Employee.txt");
                _logger.LogWarning(filePath);
                // 確保資料夾存在
                if (!Directory.Exists(uploadsDir))
                {
                    Directory.CreateDirectory(uploadsDir);
                }

                // 組合文字內容（覆蓋寫入）
                StreamWriter wr = new StreamWriter(filePath);
                wr.WriteLine(model.Id);
                wr.WriteLine(model.Name);
                wr.WriteLine(model.Birthdate.ToString("yyyy-MM-dd"));
                wr.WriteLine(model.Salary);
                wr.Close();

                ViewBag.Message = $"員工資料已儲存至 {filePath}";
            }
            else
            {
                ViewBag.EmployeeData = null;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Chart()
        {
            // 從後端提供雨量資料（可改為資料庫或服務取得）
            var rainData = new int[12];
            var uploadsDir = Path.Combine(_env.WebRootPath, "uploads");
            var filePath = Path.Combine(uploadsDir, "RainData.txt");
            StreamReader reader = new StreamReader(filePath);
            for (int i = 0; i < 12; i++)
                rainData[i] = int.Parse(reader.ReadLine());
            reader.Close();


            ViewBag.RainData = rainData;
            return View();
        }

        public List<EmployeeViewModel> LoadEmployee()
        {
            var list = new List<EmployeeViewModel>();
            try
            {
                var connStr = _config.GetConnectionString("DefaultConnection");
                using var conn = new SqlConnection(connStr);
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT emp_id, emp_name, birthdate, salary FROM dbo.Employee ORDER BY emp_id";
                cmd.CommandType = CommandType.Text;

                conn.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = new EmployeeViewModel
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Birthdate = reader.GetDateTime(2),
                        Salary = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                    };
                    list.Add(item);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "讀取 Employee 清單失敗");
            }
            return list;
        }
        public IActionResult EmployeeADO()
        {
            /*
            var employees = new List<EmployeeViewModel>
            {
            new EmployeeViewModel
                {
                    Id = 1001,
                    Name = "Alice",
                    Birthdate = new DateTime(1990, 5, 12),
                    Salary = 55000
                },
            new EmployeeViewModel
                {
                    Id = 1002,
                    Name = "Bob",
                    Birthdate = new DateTime(1990, 5, 12),
                    Salary = 62000
                },
            new EmployeeViewModel
                {
                    Id = 1003,
                    Name = "Charlie",
                    Birthdate = new DateTime(1990, 5, 12),
                    Salary = 58000
                },
            new EmployeeViewModel
                {
                    Id = 1004,
                    Name = "Diana",
                    Birthdate = new DateTime(1990, 5, 12),
                    Salary = 60000
                }
        };
            */
            var employees = LoadEmployee();
            return View(employees);
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
