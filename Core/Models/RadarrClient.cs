using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{
    public class RadarrClient
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public string ip { get; private set; }
        public string port { get; private set; }
        public string apiKey { get; private set; }
        public string fullUrl { get; private set; }

        public RadarrClient()
        {
            configParameters cp = new configParameters();

            this.ip = cp.RadarrIp;
            this.port = cp.RadarrPort;
            this.apiKey = cp.RadarrApiKey;
            this.fullUrl = "http://" + this.ip + ":" + this.port + "/api/v3/";
        }

        //get the movies from radarr or the radarr.json file, if getNew is true it will get the movies from radarr
        public async Task<List<RadarrMovies>> getMovies(bool getNew = false)
        {
            List<RadarrMovies> movieList = new List<RadarrMovies>();

            //if getNew is false and the file exists, get the movies from the file, unless it is empty
            if (!getNew && File.Exists("Data/radarr.json"))
            {
                string moviesJson = File.ReadAllText("Data/radarr.json");

                //check if seriesJson is not a json array
                if (moviesJson.StartsWith("["))
                {
                    JsonArray series = JsonArray.Parse(moviesJson).AsArray();
                    //loop throught the series and get the title
                    foreach (var s in series)
                    {
                        //add the series to the list
                        movieList.Add(new RadarrMovies(
                            s["title"]?.ToString() ?? string.Empty,
                            s["sortTitle"]?.ToString() ?? string.Empty,
                            s["year"]?.GetValue<int>() ?? 0,
                            s["tmdbId"]?.GetValue<int>() ?? 0,
                            s["imdbId"]?.ToString() ?? string.Empty,
                            s["id"]?.GetValue<int>() ?? 0,
                            s["images"]?.AsArray().FirstOrDefault(image => image["coverType"]?.ToString() == "poster")?[
                                "remoteUrl"]?.ToString() ?? string.Empty,
                            s["images"]?.AsArray().FirstOrDefault(image => image["coverType"]?.ToString() == "poster")?[
                                "url"]?.ToString() ?? string.Empty
                        ));

                    }

                }
                else
                {
                    //get the series from sonarr as the file is empty
                    getNew = true;
                }
            }
            else if (!File.Exists("Data/radarr.json"))
            {
                //get the series from sonarr as the file is empty
                getNew = true;
            }

            if (getNew)
            {
                //get the movies from radarr
                string url = this.fullUrl + "movie";
                url = url + "?apikey=" + this.apiKey;

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JsonArray movies = JsonArray.Parse(responseBody).AsArray();

                //save the json array to a file in the Data folder relative to the app
                File.WriteAllText("Data/radarr.json", movies.ToString());

                //loop throught the series and get the title
                foreach (var m in movies)
                {
                    //add the series to the list
                    movieList.Add(new RadarrMovies(
                        m["title"]?.ToString() ?? string.Empty,
                        m["sortTitle"]?.ToString() ?? string.Empty,
                        m["year"]?.GetValue<int>() ?? 0,
                        m["tmdbId"]?.GetValue<int>() ?? 0,
                        m["imdbId"]?.ToString() ?? string.Empty,
                        m["id"]?.GetValue<int>() ?? 0,
                        m["images"]?.AsArray().FirstOrDefault(image => image["coverType"]?.ToString() == "poster")?[
                            "remoteUrl"]?.ToString() ?? string.Empty,
                        m["images"]?.AsArray().FirstOrDefault(image => image["coverType"]?.ToString() == "poster")?[
                            "url"]?.ToString() ?? string.Empty
                    ));
                }

            }

            return movieList;
        }

        //lookup a movie in radarr
        public async Task<List<RadarrMovies>> lookupMovie(string lookupString)
        {
            List<RadarrMovies> moviesList = new List<RadarrMovies>();

            string url = this.fullUrl + "movie/lookup?term=" + lookupString;
            url = url + "&apikey=" + this.apiKey;

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JsonArray foundMovies = JsonArray.Parse(responseBody).AsArray();

            //save the json array to a file in the Data folder relative to the app
            File.WriteAllText("Data/radarrLookupResult.json", foundMovies.ToString());

            //loop throught the series and get the title
            foreach (var s in foundMovies)
            {
                //add the series to the list
                moviesList.Add(new RadarrMovies(
                    s["title"]?.ToString() ?? string.Empty,
                    s["sortTitle"]?.ToString() ?? string.Empty,
                    s["year"]?.GetValue<int>() ?? 0,
                    s["tmdbId"]?.GetValue<int>() ?? 0,
                    s["imdbId"]?.ToString() ?? string.Empty,
                    s["id"]?.GetValue<int>() ?? 0,
                    s["images"]?.AsArray().FirstOrDefault(image => image["coverType"]?.ToString() == "poster")?["remoteUrl"]?.ToString() ?? string.Empty,
                    s["images"]?.AsArray().FirstOrDefault(image => image["coverType"]?.ToString() == "poster")?["url"]?.ToString() ?? string.Empty
                ));
            }

            return moviesList;
        }

        //add a movie to Radarr (result from the lookup)

        //delete a movie from Radarr
    }
}

