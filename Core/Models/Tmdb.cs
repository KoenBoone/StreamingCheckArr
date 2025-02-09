using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{
    public class tmdbClient
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public string apiKey { get; private set; }
        public string token { get; private set; }
        public string fullUrl { get; private set; }

        public tmdbClient()
        {
            configParameters cp = new configParameters();
            this.apiKey = cp.TMDBApi;
            this.token = cp.TMDBToken;
            this.fullUrl = "https://api.themoviedb.org/3/";
        }

        //Check the streaming services for a movie or series (json)
        public async Task<string> getStreaming(string tvOrMovie, int id, bool getNew = false)
        {
            configParameters cp = new configParameters();

            JsonNode? json = null;

            //if the folder Data/Providers/<tvOrMovie> does not exist, create it
            if (!Directory.Exists("Data/Providers/" + tvOrMovie))
            {
                Directory.CreateDirectory("Data/Providers/" + tvOrMovie);
            }

            if (getNew)
            {
                try
                {
                    string url = this.fullUrl + tvOrMovie + "/" + id + "/watch/providers?api_key=" + this.apiKey;
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    json = JsonNode.Parse(responseBody);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error getting streaming providers: " + e.Message);
                }


                // Filter the results to keep only the object for the specified country code
                if (json["results"] is JsonObject results)
                {
                    var keys = results.AsObject().Select(kvp => kvp.Key).ToList();
                    foreach (var key in keys)
                    {
                        if (key != cp.CountryCode)
                        {
                            results.Remove(key);
                        }
                        else
                        {
                            //if the path Data/Providers/Logos does not exist, create it
                            if (!Directory.Exists("Data/Providers/Logos"))
                            {
                                Directory.CreateDirectory("Data/Providers/Logos");
                            }
                            //get all the logo_path and provider_name values from the flatrate array
                            if (results[key]["flatrate"] is JsonArray flatrate)
                            {
                                foreach (var item in flatrate)
                                {
                                    if (item is JsonObject flatrateItem)
                                    {
                                        string logoPath = flatrateItem["logo_path"].ToString();
                                        string providerName = flatrateItem["provider_name"].ToString();
                                        string logoUrl = cp.TMDBProviderLogoLocation + logoPath;
                                        string localLogoPath = "Data/Providers/Logos/" + providerName + ".jpg";

                                        //get the logo from the logoUrl and save it to the file system if it doesn't already exist
                                        if (!File.Exists(localLogoPath))
                                        {
                                            try
                                            {
                                                HttpResponseMessage logoResponse = await httpClient.GetAsync(logoUrl);
                                                logoResponse.EnsureSuccessStatusCode();
                                                byte[] logoBytes = await logoResponse.Content.ReadAsByteArrayAsync();
                                                File.WriteAllBytes(localLogoPath, logoBytes);
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine("Error getting logo: " + e.Message);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                //write the json with the updated results to a file as /Data/Providers/<tvOrMovie>/<id>.json
                if (json != null)
                {
                    File.WriteAllText("Data/Providers/" + tvOrMovie + "/" + id + ".json", json.ToString());
                }

            }
            else
            {
                //read the json from the file, if it exists, otherwise get it from the api
                if (File.Exists("Data/Providers/" + tvOrMovie + "/" + id + ".json"))
                {
                    string jsonStr = File.ReadAllText("Data/Providers/" + tvOrMovie + "/" + id + ".json");
                    if (!string.IsNullOrWhiteSpace(jsonStr))
                    {
                        try
                        {
                            json = JsonNode.Parse(jsonStr);
                        }
                        catch (JsonException ex)
                        {
                            Console.WriteLine("Error parsing JSON from file: " + ex.Message);
                            json = await getStreaming(tvOrMovie, id, true);
                        }
                    }
                    else
                    {
                        json = await getStreaming(tvOrMovie, id, true);
                    }
                }
                else
                {
                    json = await getStreaming(tvOrMovie, id, true);
                }
            }

            //return the json as a string
            return json.ToString();
        }
    }
}
