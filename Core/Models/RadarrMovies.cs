using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{
    public class RadarrMovies
    {
        public string title { get; set; }
        public string sortTitle { get; set; }
        public int year { get; set; }
        public int tmdbId { get; set; }
        public string imdbId { get; set; }
        public int id { get; set; }
        public string remotePoster { get; set; }
        public string localPoster { get; set; }

        //constructor
        public RadarrMovies(string title, string sortTitle, int year, int tmdbId, string imdbId, int id, string remotePoster, string localPoster)
        {
            this.title = title;
            this.sortTitle = sortTitle;
            this.year = year;
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
