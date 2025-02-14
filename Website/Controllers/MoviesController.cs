using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StreamingCheckArr.Core.Models;

namespace StreamingCheckArr.Website.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index(bool getNew = false)
        {
            //get the movies from radarr
            RadarrClient rc = new RadarrClient();
            List<RadarrMovies> movies = rc.getMovies(getNew).Result.ToList();

            return View(movies);
        }

        //get the streaming providers for all movies where the tmdbid is not 0
        //WARNING: do not abuse this!!!!
        public IActionResult GetStreamersAll()
        {
            //get the series from the json file /Data/radarr.json
            RadarrClient rc = new RadarrClient();
            List<RadarrMovies> movies = rc.getMovies(false).Result.ToList();

            tmdbClient tmdb = new tmdbClient();

            foreach (RadarrMovies s in movies)
            {
                if (s.tmdbId != 0)
                {
                    _ = tmdb.getStreaming("movie", s.tmdbId, true).Result;
                }
            }
            //redirect to the streamers page
            return RedirectToAction("Index");
        }

        //Get the streaming providers for a movie (refresh)
        public IActionResult RefreshStreamers(int tmdbID)
        {
            //get the streaming providers for the series
            tmdbClient tmdb = new tmdbClient();
            _ = tmdb.getStreaming("movie", tmdbID, true).Result;

            return ViewComponent("Streamers", new { tmdbID, movieOrSeries = "movie" });
        }

    }
}
