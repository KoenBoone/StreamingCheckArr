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
        public string title { get; set; }
        public Alternatetitle[] alternateTitles { get; set; }
        public string sortTitle { get; set; }
        public string status { get; set; }
        public bool ended { get; set; }
        public string overview { get; set; }
        public DateTime previousAiring { get; set; }
        public string network { get; set; }
        public Image[] images { get; set; }
        public Originallanguage originalLanguage { get; set; }
        public Season[] seasons { get; set; }
        public int year { get; set; }
        public string path { get; set; }
        public int qualityProfileId { get; set; }
        public bool seasonFolder { get; set; }
        public bool monitored { get; set; }
        public string monitorNewItems { get; set; }
        public bool useSceneNumbering { get; set; }
        public int runtime { get; set; }
        public int tvdbId { get; set; }
        public int tvRageId { get; set; }
        public int tvMazeId { get; set; }
        public int tmdbId { get; set; }
        public DateTime firstAired { get; set; }
        public DateTime lastAired { get; set; }
        public string seriesType { get; set; }
        public string cleanTitle { get; set; }
        public string imdbId { get; set; }
        public string titleSlug { get; set; }
        public string rootFolderPath { get; set; }
        public string certification { get; set; }
        public string[] genres { get; set; }
        public int?[] tags { get; set; }
        public DateTime added { get; set; }
        public Ratings ratings { get; set; }
        public Statistics statistics { get; set; }
        public int languageProfileId { get; set; }
        public int id { get; set; }
        public string airTime { get; set; }
        public DateTime nextAiring { get; set; }
    }

    public class Originallanguage
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Ratings
    {
        public int votes { get; set; }
        public float value { get; set; }
    }

    public class Statistics
    {
        public int seasonCount { get; set; }
        public int episodeFileCount { get; set; }
        public int episodeCount { get; set; }
        public int totalEpisodeCount { get; set; }
        public long sizeOnDisk { get; set; }
        public string[] releaseGroups { get; set; }
        public float percentOfEpisodes { get; set; }
    }

    public class Alternatetitle
    {
        public string title { get; set; }
        public int seasonNumber { get; set; }
        public int sceneSeasonNumber { get; set; }
        public string comment { get; set; }
    }

    public class Image
    {
        public string coverType { get; set; }
        public string url { get; set; }
        public string remoteUrl { get; set; }
    }

    public class Season
    {
        public int seasonNumber { get; set; }
        public bool monitored { get; set; }
        public Statistics1 statistics { get; set; }
    }

    public class Statistics1
    {
        public DateTime previousAiring { get; set; }
        public int episodeFileCount { get; set; }
        public int episodeCount { get; set; }
        public int totalEpisodeCount { get; set; }
        public long sizeOnDisk { get; set; }
        public string[] releaseGroups { get; set; }
        public float percentOfEpisodes { get; set; }
        public DateTime nextAiring { get; set; }
    }

}
