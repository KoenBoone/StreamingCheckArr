using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{
    public class SonarrClient
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public string ip { get; private set; }
        public string port { get; private set; }
        public string apiKey { get; private set; }
        public string fullUrl { get; private set; }

        public SonarrClient()
        {
            configParameters cp = new configParameters();

            this.ip = cp.SonarrIp;
            this.port = cp.SonarrPort;
            this.apiKey = cp.SonarrApiKey;
            this.fullUrl = "http://" + this.ip + ":" + this.port + "/api/v3/";
        }

        public async Task<List<SonarrSeries>> getSeries()
        {
            //get the series from sonarr
            string url = this.fullUrl + "series";
            url = url + "?apikey=" + this.apiKey;

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JsonArray series = JsonArray.Parse(responseBody).AsArray();

            List<SonarrSeries> seriesList = new List<SonarrSeries>();

            //loop throught the series and get the title
            foreach (var s in series)
            {
                //add the series to the list
                seriesList.Add(new SonarrSeries(
                    s["title"]?.ToString() ?? string.Empty,
                    s["sortTitle"]?.ToString() ?? string.Empty,
                    s["year"]?.GetValue<int>() ?? 0,
                    s["tvdbId"]?.GetValue<int>() ?? 0,
                    s["tvRageId"]?.GetValue<int>() ?? 0,
                    s["tvMazeId"]?.GetValue<int>() ?? 0,
                    s["tmdbId"]?.GetValue<int>() ?? 0,
                    s["imdbId"]?.ToString() ?? string.Empty,
                    s["id"]?.GetValue<int>() ?? 0
                ));
            }

            return seriesList;
        }
    }
}
