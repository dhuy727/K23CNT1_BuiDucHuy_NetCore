using Bdhlession07.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Bdhlession07.Models;

namespace BdhLesson07.Controllers
{
    public class BdhHomeController : Controller
    {
        private readonly ILogger<BdhHomeController> _logger;

        public BdhHomeController(ILogger<BdhHomeController> logger)
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