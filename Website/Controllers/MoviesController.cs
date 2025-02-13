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
    }
}
