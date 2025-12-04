using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using WebApplication1.Models;
namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _config;
    public HomeController(ILogger<HomeController> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }
        private string GetConnStr() => _config.GetConnectionString("DefaultConnection") ?? "";

    public IActionResult Index()
    {
        ViewBag.Data = "Hello world!";
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
    public IActionResult Employee(int id, string name, DateTime? birthdate, int salary)
    {
        ViewBag.EmployeeData = new
        {
            Id = id,
            Name = name,
            Birthdate = birthdate,
            Salary = salary
        };
        return View("EmployeeResult");
    }

    [HttpGet]
    public IActionResult EmployeeCombine()
    {
        return View();
    }
    [HttpPost]
    public IActionResult EmployeeCombine(int id, string name, DateTime? birthdate, int salary)
    {


        ViewBag.EmployeeData = new
        {
            Id = id,
            Name = name,
            Birthdate = birthdate ?? new DateTime(),
            Salary = salary
        };
        return View();
    }

    [HttpGet]
    public IActionResult EmployeeModel()
    {
        return View();
    }

    [HttpPost]
    public IActionResult EmployeeModel(EmployeeViewModel model)
    {
        if (ModelState.IsValid)
            ViewBag.EmployeeData = model;
        else
            ViewBag.EmployeeData = null;

        return View();
    }

    [HttpGet]
    public IActionResult EmployeeSave()
    {
        EmployeeViewModel model = new EmployeeViewModel();
        
        try
        {
            string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            string filePath = uploadsFolder +  "\\Employee.txt";

            if (System.IO.File.Exists(filePath))
            {
                using (StreamReader rd = new StreamReader(filePath, System.Text.Encoding.UTF8))
                {
                    model.Id = int.Parse(rd.ReadLine());
                    model.Name = rd.ReadLine();
                    model.Birthdate = DateTime.Parse(rd.ReadLine());
                    model.Salary = int.Parse(rd.ReadLine());
                    rd.Close();
                }
                ViewBag.ReadMessage = "已成功讀取檔案資料並載入表單";
            }
            else
            {
                ViewBag.FileContent = null;
                ViewBag.ReadMessage = "檔案尚未建立，請先儲存資料";
            }
        }
        catch (Exception ex)
        {
            ViewBag.ReadMessage = $"讀取失敗: {ex.Message}";
            ViewBag.FileContent = null;
        }

        return View(model);
    }

    [HttpPost]
    public IActionResult EmployeeSave(EmployeeViewModel model)
    {
        if (ModelState.IsValid)
        {
            try
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");                
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                string filePath = uploadsFolder +  "\\Employee.txt";
                StreamWriter wr = new StreamWriter(filePath, false, System.Text.Encoding.UTF8);
                wr.WriteLine(model.Id);
                wr.WriteLine(model.Name);
                wr.WriteLine(model.Birthdate);
                wr.WriteLine(model.Salary);
                wr.Close();
                ViewBag.EmployeeData = model;
                ViewBag.SaveMessage = "資料已成功儲存！";
            }
            catch (Exception ex)
            {
                ViewBag.SaveMessage = $"儲存失敗: {ex.Message}";
                ViewBag.EmployeeData = model;
            }
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
        // 後端準備資料
        var months = new[] { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };
        var rainfallMm = new[] { 83.5, 170.0, 180.0, 178.8, 234.6, 325.3, 247.1, 352.5, 284.4, 112.0, 84.8, 136.3 };

        // 序列化給前端使用
        ViewBag.MonthsJson = JsonSerializer.Serialize(months);
        ViewBag.RainfallJson = JsonSerializer.Serialize(rainfallMm);

        return View();
    }

    
    [HttpGet]
    public IActionResult ChartSave()
    {
        var months = new[] { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };
        double[] rainfall = new[] { 83.5, 170.0, 180.0, 178.8, 234.6, 325.3, 247.1, 352.5, 284.4, 112.0, 84.8, 136.3 };

        try
        {
            string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            string jsonPath = Path.Combine(uploadsFolder, "rainfall.json");
            if (System.IO.File.Exists(jsonPath))
            {
                var json = System.IO.File.ReadAllText(jsonPath);
                var loaded = JsonSerializer.Deserialize<double[]>(json);
                if (loaded != null && loaded.Length == 12)
                {
                    rainfall = loaded;
                }
            }
        }
        catch
        {
            // 若讀取失敗，使用預設 rainfall
        }

        var model = WebApplication1.Models.RainDataViewModel.FromArray(rainfall);

        ViewBag.MonthsJson = JsonSerializer.Serialize(months);
        ViewBag.RainfallJson = JsonSerializer.Serialize(rainfall);
        return View(model);
    }

    [HttpPost]
    public IActionResult ChartSave(WebApplication1.Models.RainDataViewModel model)
    {
        var months = new[] { "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };

        if (!ModelState.IsValid)
        {
            ViewBag.MonthsJson = JsonSerializer.Serialize(months);
            ViewBag.RainfallJson = JsonSerializer.Serialize(model.ToArray());
            ViewBag.SaveMessage = "資料驗證失敗，請修正後再試。";
            return View(model);
        }

        try
        {
            string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string jsonPath = Path.Combine(uploadsFolder, "rainfall.json");
            var data = model.ToArray();
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(jsonPath, json);

            ViewBag.SaveMessage = "雨量資料已儲存。";
            // 回傳同頁且以剛儲存的資料重繪圖表
            ViewBag.MonthsJson = JsonSerializer.Serialize(months);
            ViewBag.RainfallJson = JsonSerializer.Serialize(data);
            return View(model);
        }
        catch (Exception ex)
        {
            ViewBag.SaveMessage = $"儲存失敗：{ex.Message}";
            ViewBag.MonthsJson = JsonSerializer.Serialize(months);
            ViewBag.RainfallJson = JsonSerializer.Serialize(model.ToArray());
            return View(model);
        }
    }
    public IActionResult Privacy()
    {
        return View();
    }

    private IEnumerable<EmployeeViewModel> EmployeeLoadAll()
    {
        var list = new List<EmployeeViewModel>();
        try
        {
            using var conn = new SqlConnection(GetConnStr());
            conn.Open();
            using var cmd = new SqlCommand(
                "SELECT emp_id, emp_name, birthdate, salary FROM dbo.Employee ORDER BY emp_id", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EmployeeViewModel
                {
                    Id = reader.GetInt32(0),
                    Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    Birthdate = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                    Salary = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                });
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "讀取 Employee 清單失敗");
            TempData["Msg"] = $"讀取失敗：{ex.Message}";
        }
        return list;
    }

    [HttpGet]
    public IActionResult EmployeeADO()
    {
        var list = new List<EmployeeViewModel>(EmployeeLoadAll());
        return View(list);
    }

    [HttpGet]
    public IActionResult EmployeeCreate()
    {
        return View("EmployeeADO_Form", new EmployeeViewModel());
    }

    [HttpPost]
    public IActionResult EmployeeCreate(EmployeeViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("EmployeeADO_Form", model);
        }

        try
        {
            using var conn = new SqlConnection(GetConnStr());
            conn.Open();
            using var cmd = new SqlCommand(
                "INSERT INTO dbo.Employee (emp_name, birthdate, salary) VALUES (@Name, @Birthdate, @Salary)", conn);
            cmd.Parameters.AddWithValue("@Name", (object?)model.Name ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Birthdate", (object?)model.Birthdate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Salary", model.Salary);
            cmd.ExecuteNonQuery();
            TempData["Msg"] = "新增成功";
            return RedirectToAction(nameof(EmployeeADO));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "新增 Employee 失敗");
            ModelState.AddModelError(string.Empty, $"新增失敗：{ex.Message}");
            return View("EmployeeADO_Form", model);
        }
    }

    [HttpGet]
    public IActionResult EmployeeEdit(int id)
    {
        var model = new EmployeeViewModel();
        try
        {
            using var conn = new SqlConnection(GetConnStr());
            conn.Open();
            using var cmd = new SqlCommand(
                "SELECT emp_id, emp_name, birthdate, salary FROM dbo.Employee WHERE emp_id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                model.Id = reader.GetInt32(0);
                model.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                model.Birthdate = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2);
                model.Salary = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
            }
            else
            {
                TempData["Msg"] = "資料不存在";
                return RedirectToAction(nameof(EmployeeADO));
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "讀取 Employee 失敗");
            TempData["Msg"] = $"讀取失敗：{ex.Message}";
            return RedirectToAction(nameof(EmployeeADO));
        }
        return View("EmployeeADO_Form", model);
    }

    [HttpPost]
    public IActionResult EmployeeEdit(EmployeeViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("EmployeeADO_Form", model);
        }

        try
        {
            using var conn = new SqlConnection(GetConnStr());
            conn.Open();
            using var cmd = new SqlCommand(
                "UPDATE dbo.Employee SET emp_name=@Name, birthdate=@Birthdate, salary=@Salary WHERE emp_id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", model.Id);
            cmd.Parameters.AddWithValue("@Name", (object?)model.Name ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Birthdate", (object?)model.Birthdate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Salary", model.Salary);
            var rows = cmd.ExecuteNonQuery();
            TempData["Msg"] = rows > 0 ? "更新成功" : "未更新任何資料";
            return RedirectToAction(nameof(EmployeeADO));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "更新 Employee 失敗");
            ModelState.AddModelError(string.Empty, $"更新失敗：{ex.Message}");
            return View("EmployeeADO_Form", model);
        }
    }

    [HttpPost]
    public IActionResult EmployeeDelete(int id)
    {
        try
        {
            using var conn = new SqlConnection(GetConnStr());
            conn.Open();
            using var cmd = new SqlCommand("DELETE FROM dbo.Employee WHERE emp_id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            var rows = cmd.ExecuteNonQuery();
            TempData["Msg"] = rows > 0 ? "刪除成功" : "資料不存在或已刪除";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "刪除 Employee 失敗");
            TempData["Msg"] = $"刪除失敗：{ex.Message}";
        }
        return RedirectToAction(nameof(EmployeeADO));
    }

    [HttpPost]
    public IActionResult EmployeeExportPdf()
    {
        try
        {
            var employees = EmployeeLoadAll().ToList();

            string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            string filePath = Path.Combine(uploadsFolder, "Employee.pdf");
            string fontPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "fonts", "NotoSansTC-Regular.ttf");

            // 建立 PDF 文件
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            using (var doc = new Document(PageSize.A4, 36, 36, 36, 36))
            using (var writer = PdfWriter.GetInstance(doc, fs))
            {
                doc.Open();

                // 載入中文字型
                var baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                var titleFont = new Font(baseFont, 18, Font.BOLD);
                var headerFont = new Font(baseFont, 12, Font.BOLD);
                var rowFont = new Font(baseFont, 12, Font.NORMAL);

                // 標題
                doc.Add(new Paragraph("員工清單", titleFont));
                doc.Add(new Paragraph("\n"));

                // 建立表格
                PdfPTable table = new PdfPTable(4) { WidthPercentage = 100 };
                table.SetWidths(new float[] { 1, 2, 2, 1 });

                // 表頭
                table.AddCell(new PdfPCell(new Phrase("編號", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("姓名", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("出生年月日", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("薪資", headerFont)));

                // 資料列
                foreach (var e in employees)
                {
                    table.AddCell(new PdfPCell(new Phrase(e.Id.ToString(), rowFont)));
                    table.AddCell(new PdfPCell(new Phrase(e.Name ?? "", rowFont)));
                    table.AddCell(new PdfPCell(new Phrase(e.Birthdate?.ToString("yyyy-MM-dd") ?? "", rowFont)));
                    table.AddCell(new PdfPCell(new Phrase(e.Salary.ToString(), rowFont)));
                }

                doc.Add(table);
                doc.Close();
            }

            TempData["Msg"] = "PDF 已產生";
            TempData["DownloadLink"] = "/uploads/Employee.pdf";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "匯出 PDF 失敗");
            TempData["Msg"] = $"匯出失敗：{ex.Message}";
        }

        return RedirectToAction(nameof(EmployeeADO));
    }

    [HttpPost]
    public IActionResult EmployeeExportExcel()
    {
        try
        {
            var employees = EmployeeLoadAll().ToList();

            string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            string filePath = Path.Combine(uploadsFolder, "Employee.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("員工清單");
                // 標題列
                ws.Cell(1, 1).Value = "編號";
                ws.Cell(1, 2).Value = "姓名";
                ws.Cell(1, 3).Value = "出生年月日";
                ws.Cell(1, 4).Value = "薪資";
                ws.Row(1).Style.Font.Bold = true;

                // 資料列
                int row = 2;
                foreach (var e in employees)
                {
                    ws.Cell(row, 1).Value = e.Id;
                    ws.Cell(row, 2).Value = e.Name ?? "";
                    ws.Cell(row, 3).Value = e.Birthdate?.ToString("yyyy-MM-dd") ?? "";
                    ws.Cell(row, 4).Value = e.Salary;
                    row++;
                }
                ws.Columns().AdjustToContents();
                workbook.SaveAs(filePath);
            }

            TempData["Msg"] = "Excel 已產生";
            TempData["DownloadLinkExcel"] = "/uploads/Employee.xlsx";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "匯出 Excel 失敗");
            TempData["Msg"] = $"匯出失敗：{ex.Message}";
        }

        return RedirectToAction(nameof(EmployeeADO));
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
