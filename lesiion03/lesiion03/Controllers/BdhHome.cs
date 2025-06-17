using System.Diagnostics;
using lesiion03.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesiion03.Controllers
{
    public class BdhHome : Controller
    {
        private readonly ILogger<BdhHome> _logger;

        public BdhHome(ILogger<BdhHome> logger)
        {
            _logger = logger;
        }

        public IActionResult BdhIndex()
        {
            return View();
        }

        public IActionResult BdhAbout()
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
