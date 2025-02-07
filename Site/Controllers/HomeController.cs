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

            ViewBag.SonarrIp = cp.SonarrIp;
            ViewBag.RadarrIp = cp.RadarrIp;
            ViewBag.SonarrPort = cp.SonarrPort;
            ViewBag.RadarrPort = cp.RadarrPort;
            ViewBag.SonarrApiKey = cp.SonarrApiKey;
            ViewBag.RadarrApiKey = cp.RadarrApiKey;
            ViewBag.TraktClientId = cp.TraktClientId;
            ViewBag.TraktClientSecret = cp.TraktClientSecret;
            ViewBag.TMDBApi = cp.TMDBApi;
            ViewBag.TMDBToken = cp.TMDBToken;
            ViewBag.CountryCode = cp.CountryCode;

            //get the series from sonarr
            SonarrClient sc = new SonarrClient();
            List<SonarrSeries> series = sc.getSeries().Result.ToList();

            ViewBag.Series = series;

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
