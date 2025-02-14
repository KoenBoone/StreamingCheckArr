using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using StreamingCheckArr.Core.Models;

namespace StreamingCheckArr.Website.Components
{
    [ViewComponent(Name = "Streamers")]
    public class StreamersViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int tmdbID, string movieOrSeries)
        {
            configParameters cp = new configParameters();
            ViewBag.tmdbID = tmdbID;
            ViewBag.LastModified = null;
            string localLogoPath = "/Data/Providers/Logos/";
            List<string> logos = new List<string>();

            //read the json file in Data/Providers/<movieOrSeries>/{tmdbID}.json (if it exists)
            string jsonFile = "Data/Providers/" + movieOrSeries + "/" + tmdbID + ".json";
            if (System.IO.File.Exists(jsonFile))
            {
                //get the date the file was last modified
                System.IO.FileInfo fi = new System.IO.FileInfo(jsonFile);
                ViewBag.LastModified = fi.LastWriteTime;

                string json = System.IO.File.ReadAllText(jsonFile);

                //check if it is not empty or null or an empty array
                if (string.IsNullOrEmpty(json) || json == "[]" || json == "{}")
                {
                    return View("_Streamers", logos);
                }

                //create json object
                JsonNode jn = JsonNode.Parse(json);
                
                //check if it contains a results object
                if (jn["results"] == null)
                {
                    return View("_Streamers", logos);
                }
                JsonNode results = jn["results"];

                //check if it contains a country code object
                if (results[cp.CountryCode] == null)
                {
                    return View("_Streamers", logos);
                }
                JsonNode resultsCountry = results[cp.CountryCode];

                //get all the logo_path and provider_name values from the flatrate array (if flatrate is not empty)
                if (resultsCountry["flatrate"] != null)
                {
                    JsonArray flatrate = resultsCountry["flatrate"].AsArray();

                    foreach (var item in flatrate)
                    {
                        logos.Add(localLogoPath + item["provider_name"].ToString() + ".jpg");
                    }
                }

                //get all the logo_path and provider_name values from the free array (if free is not empty)
                if (resultsCountry["free"] != null)
                {
                    JsonArray free = resultsCountry["free"].AsArray();
                    foreach (var item in free)
                    {
                        logos.Add(localLogoPath + item["provider_name"].ToString() + ".jpg");
                    }
                }
                
            }

            //return the partial view with the logos
            return View("_Streamers", logos);

        }
    }
}
