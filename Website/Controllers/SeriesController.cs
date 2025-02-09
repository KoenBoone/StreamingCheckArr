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

        //Get the streaming providers for a series
        public IActionResult GetStreamers(int tmdbID)
        {
            //get the streaming providers for the series
            tmdbClient tmdb = new tmdbClient();
            _ = tmdb.getStreaming("tv", tmdbID, true).Result;

            //redirect to the streamers page
            return RedirectToAction("Index");
        }
    }
}
