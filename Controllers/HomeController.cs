using BLOC3ProjetReservationJO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace BLOC3ProjetReservationJO.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult logIn()
        {
            return View();
        }
        public IActionResult CreateAccompt()
        {
            return View();
        }

        public IActionResult command()
        {
            return View();
        }

        public IActionResult Offre()
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
