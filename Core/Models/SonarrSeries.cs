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

        public SonarrSeries(string title, string sortTitle, int year, int tvdbId, int tvRageId, int tvMazeId, int tmdbId, string imdbId, int id)
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
        }

        public override string ToString()
        {
            return title + " (" + year + ")";
        }
    }
}
