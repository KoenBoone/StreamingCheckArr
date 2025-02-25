using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;
using StreamingCheckArr.Core.Models;

namespace StreamingCheckArr.Website.Components
{
    [ViewComponent(Name = "StreamersFilter")]
    public class StreamerFilterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string type)
        {
            //get all the distinct streamers for the type
            List<StreamerFilter> streamers = new List<StreamerFilter>();

            configParameters cp = new configParameters();

            if (type != "tv" && type != "movie")
            {
                return View("_StreamersFilter", streamers);
            }

            //read and parse all the json files in Data/Providers/<type>/ to get the streamers
            string jsonPath = "Data/Providers/" + type + "/";
            string logoPath = "/Data/Providers/Logos/";
            string[] files = System.IO.Directory.GetFiles(jsonPath);
            foreach (string file in files)
            {
                if (file.EndsWith(".json"))
                {
                    string json = System.IO.File.ReadAllText(file);
                    if (!string.IsNullOrEmpty(json) && json != "[]" && json != "{}")
                    {
                        //create json object
                        JsonNode jn = JsonNode.Parse(json);
                        //check if it contains a results object
                        if (jn["results"] != null)
                        {
                            JsonNode results = jn["results"];
                            //check if it contains a country code object
                            if (results[cp.CountryCode] != null)
                            {
                                JsonNode resultsCountry = results[cp.CountryCode];
                                //get all the logo_path and provider_name values from the flatrate array (if flatrate is not empty)
                                if (resultsCountry["flatrate"] != null)
                                {
                                    JsonArray flatrate = resultsCountry["flatrate"].AsArray();
                                    foreach (var item in flatrate)
                                    {
                                        streamers.Add(new StreamerFilter(item["provider_name"].ToString(),
                                            logoPath + item["provider_name"] + ".jpg", cp.CountryCode, type));
                                    }
                                }

                                //get all the logo_path and provider_name values from the free array (if free is not empty)
                                if (resultsCountry["free"] != null)
                                {
                                    JsonArray free = resultsCountry["free"].AsArray();
                                    foreach (var item in free)
                                    {
                                        streamers.Add(new StreamerFilter(item["provider_name"].ToString(),
                                            logoPath + item["provider_name"] + ".jpg", cp.CountryCode, type));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //order the streamers by logopath and remove doubles
            streamers = streamers.GroupBy(s => s.Name)
                                 .Select(g => g.First())
                                 .OrderBy(s => s.LogoPath)
                                 .ToList();

            return View("_StreamersFilter", streamers);
        }
    }
}
