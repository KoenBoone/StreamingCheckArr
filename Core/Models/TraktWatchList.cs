using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingCheckArr.Core.Models
{

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int rank { get; set; }
        public int id { get; set; }
        public DateTime listed_at { get; set; }
        public string type { get; set; }
        public Movie movie { get; set; }
        public Show show { get; set; }
    }

    public class Movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public Ids ids { get; set; }
    }

    public class Ids
    {
        public int trakt { get; set; }
        public string slug { get; set; }
        public string imdb { get; set; }
        public int tmdb { get; set; }
    }

    public class Show
    {
        public string title { get; set; }
        public int year { get; set; }
        public Ids1 ids { get; set; }
    }

    public class Ids1
    {
        public int trakt { get; set; }
        public string slug { get; set; }
        public string imdb { get; set; }
        public int tmdb { get; set; }
    }

}
