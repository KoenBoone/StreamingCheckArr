using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using StreamingCheckArr.Core.Models;

namespace StreamingCheckArr.Website.Components
{
    [ViewComponent]
    public class StreamersViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int tmdbID)
        {
            configParameters cp = new configParameters();
            ViewBag.tmdbID = tmdbID;
            string localLogoPath = "/Data/Providers/Logos/";
            List<string> logos = new List<string>();

            //read the json file in Data/Providers/tv/{tmdbID}.json (if it exists)
            string jsonFile = "Data/Providers/tv/" + tmdbID + ".json";
            if (System.IO.File.Exists(jsonFile))
            {
                string json = System.IO.File.ReadAllText(jsonFile);

                //create json object
                JsonNode jn = JsonNode.Parse(json);
                JsonNode results = jn["results"];
                JsonNode resultsCountry = results[cp.CountryCode];

                //get all the logo_path and provider_name values from the flatrate array
                JsonArray flatrate = resultsCountry["flatrate"].AsArray();

                foreach (var item in flatrate)
                {
                    logos.Add(localLogoPath + item["provider_name"].ToString() + ".jpg");
                }
            }

            //return the partial view with the logos
            return View("_Streamers", logos);

        }
    }
}
