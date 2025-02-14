using Microsoft.AspNetCore.Mvc;
using StreamingCheckArr.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using Microsoft.CodeAnalysis;

namespace StreamingCheckArr.Website.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index(bool getNew = false)
        {
            //get the series from sonarr
            SonarrClient sc = new SonarrClient();
            List<SonarrSeries> series = sc.getSeries(getNew).Result.ToList();

            return View(series);
        }

        //get the streaming providers for all series where the tmdbid is not 0
        //WARNING: do not abuse this!!!!
        public IActionResult GetStreamersAll()
        {
            //get the series from the json file /Data/sonarr.json
            SonarrClient sc = new SonarrClient();
            List<SonarrSeries> series = sc.getSeries(false).Result.ToList();

            tmdbClient tmdb = new tmdbClient();

            foreach (SonarrSeries s in series)
            {
                if (s.tmdbId != 0)
                {
                    _ = tmdb.getStreaming("tv", s.tmdbId, true).Result;
                }
            }
            //redirect to the streamers page
            return RedirectToAction("Index");
        }

        //Get the streaming providers for a series (refresh)
        public IActionResult RefreshStreamers(int tmdbID)
        {
            //get the streaming providers for the series
            tmdbClient tmdb = new tmdbClient();
            _ = tmdb.getStreaming("tv", tmdbID, true).Result;

            return ViewComponent("Streamers", new { tmdbID, movieOrSeries = "tv" });
        }
    }
}
