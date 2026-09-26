using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using buivanlong_2410900047_exam.Models;

namespace buivanlong_2410900047_exam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Action hiển thị thông tin sinh viên Bùi Văn Long
        public IActionResult HvtAbout()
        {
            ViewBag.HvtName = "Bùi Văn Long";
            ViewBag.HvtMaSV = "2410900047";
            ViewBag.HvtClass = "Công Nghệ Thông Tin";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}