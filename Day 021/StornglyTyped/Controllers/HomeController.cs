using Microsoft.AspNetCore.Mvc;
using StornglyTyped.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace StornglyTyped.Controllers
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
            var Cla = new List<Class>()
            {
                new Class { ID = 101, Name ="홍길동", Position = "대리", Salary = 35000 },
                new Class { ID = 102, Name ="강감찬", Position = "부장", Salary = 60000 },
                new Class { ID = 103, Name ="이순신", Position = "상무", Salary = 70000 }
            };
            return View(Cla);
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
