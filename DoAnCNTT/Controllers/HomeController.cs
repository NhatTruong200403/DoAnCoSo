using DoAnCNTT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoAnCNTT.Controllers
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

        public IActionResult ChinhSach()
        {
            return View();
        }
        public IActionResult Dieukhoan()
        {
            return View();
        }
        public IActionResult GioiThieu()
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
