using System.Diagnostics;
using Core;
using Microsoft.AspNetCore.Mvc;
using StreamingCheckArr.Core.Models;
using StreamingCheckArr.Site.Models;

namespace StreamingCheckArr.Site.Controllers
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
            configParameters cp = new configParameters();

            ViewBag.SonarrUrl = cp.SonarrUrl;
            ViewBag.RadarrUrl = cp.RadarrUrl;
            ViewBag.SonarrApiKey = cp.SonarrApiKey;
            ViewBag.RadarrApiKey = cp.RadarrApiKey;
            ViewBag.TraktClientId = cp.TraktClientId;
            ViewBag.TraktClientSecret = cp.TraktClientSecret;
            ViewBag.TMDBApi = cp.TMDBApi;
            ViewBag.TMDBToken = cp.TMDBToken;
            ViewBag.CountryCode = cp.CountryCode;

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
