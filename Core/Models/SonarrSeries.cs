using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{
    public class SonarrSeries
    {
        public string title { get; set; }
        public string sortTitle { get; set; }
        public int year { get; set; }
        public int tvdbId { get; set; }
        public int tvRageId { get; set; }
        public int tvMazeId { get; set; }
        public int tmdbId { get; set; }
        public string imdbId { get; set; }
        public int id { get; set; }
        public string remotePoster { get; set; }
        public string localPoster { get; set; }

        public SonarrSeries(string title, string sortTitle, int year, int tvdbId, int tvRageId, int tvMazeId, int tmdbId, string imdbId, int id, string remotePoster, string localPoster)
        {
            this.title = title;
            this.sortTitle = sortTitle;
            this.year = year;
            this.tvdbId = tvdbId;
            this.tvRageId = tvRageId;
            this.tvMazeId = tvMazeId;
            this.tmdbId = tmdbId;
            this.imdbId = imdbId;
            this.id = id;
            this.remotePoster = remotePoster;
            this.localPoster = localPoster;
        }

        public override string ToString()
        {
            return title + " (" + year + ")";
        }
    }
}
