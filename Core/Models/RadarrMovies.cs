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
        public string originalTitle { get; set; }
        public Originallanguage originalLanguage { get; set; }
        public Alternatetitle[] alternateTitles { get; set; }
        public int secondaryYearSourceId { get; set; }
        public string sortTitle { get; set; }
        public long sizeOnDisk { get; set; }
        public string status { get; set; }
        public string overview { get; set; }
        public DateTime inCinemas { get; set; }
        public DateTime releaseDate { get; set; }
        public Image[] images { get; set; }
        public string website { get; set; }
        public int year { get; set; }
        public string youTubeTrailerId { get; set; }
        public string studio { get; set; }
        public string path { get; set; }
        public int qualityProfileId { get; set; }
        public bool hasFile { get; set; }
        public int movieFileId { get; set; }
        public bool monitored { get; set; }
        public string minimumAvailability { get; set; }
        public bool isAvailable { get; set; }
        public string folderName { get; set; }
        public int runtime { get; set; }
        public string cleanTitle { get; set; }
        public string imdbId { get; set; }
        public int tmdbId { get; set; }
        public string titleSlug { get; set; }
        public string rootFolderPath { get; set; }
        public string[] genres { get; set; }
        public int?[] tags { get; set; }
        public DateTime added { get; set; }
        public Ratings ratings { get; set; }
        public Moviefile movieFile { get; set; }
        public float popularity { get; set; }
        public DateTime lastSearchTime { get; set; }
        public Statistics statistics { get; set; }
        public int id { get; set; }
        public string certification { get; set; }
        public DateTime digitalRelease { get; set; }
        public DateTime physicalRelease { get; set; }
        public int secondaryYear { get; set; }
        public Collection collection { get; set; }
    }

    public class Originallanguage
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Ratings
    {
        public Imdb imdb { get; set; }
        public Tmdb tmdb { get; set; }
        public Metacritic metacritic { get; set; }
        public Rottentomatoes rottenTomatoes { get; set; }
        public Trakt trakt { get; set; }
    }

    public class Imdb
    {
        public int votes { get; set; }
        public float value { get; set; }
        public string type { get; set; }
    }

    public class Tmdb
    {
        public int votes { get; set; }
        public float value { get; set; }
        public string type { get; set; }
    }

    public class Metacritic
    {
        public int votes { get; set; }
        public int value { get; set; }
        public string type { get; set; }
    }

    public class Rottentomatoes
    {
        public int votes { get; set; }
        public int value { get; set; }
        public string type { get; set; }
    }

    public class Trakt
    {
        public int votes { get; set; }
        public float value { get; set; }
        public string type { get; set; }
    }

    public class Moviefile
    {
        public int movieId { get; set; }
        public string relativePath { get; set; }
        public string path { get; set; }
        public long size { get; set; }
        public DateTime dateAdded { get; set; }
        public string sceneName { get; set; }
        public string releaseGroup { get; set; }
        public string edition { get; set; }
        public Language[] languages { get; set; }
        public Quality quality { get; set; }
        public int customFormatScore { get; set; }
        public int indexerFlags { get; set; }
        public Mediainfo mediaInfo { get; set; }
        public string originalFilePath { get; set; }
        public bool qualityCutoffNotMet { get; set; }
        public int id { get; set; }
    }

    public class Quality
    {
        public Quality1 quality { get; set; }
        public Revision revision { get; set; }
    }

    public class Quality1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string source { get; set; }
        public int resolution { get; set; }
        public string modifier { get; set; }
    }

    public class Revision
    {
        public int version { get; set; }
        public int real { get; set; }
        public bool isRepack { get; set; }
    }

    public class Mediainfo
    {
        public int audioBitrate { get; set; }
        public float audioChannels { get; set; }
        public string audioCodec { get; set; }
        public string audioLanguages { get; set; }
        public int audioStreamCount { get; set; }
        public int videoBitDepth { get; set; }
        public int videoBitrate { get; set; }
        public string videoCodec { get; set; }
        public float videoFps { get; set; }
        public string videoDynamicRange { get; set; }
        public string videoDynamicRangeType { get; set; }
        public string resolution { get; set; }
        public string runTime { get; set; }
        public string scanType { get; set; }
        public string subtitles { get; set; }
    }

    public class Language
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Statistics
    {
        public int movieFileCount { get; set; }
        public long sizeOnDisk { get; set; }
        public string[] releaseGroups { get; set; }
    }

    public class Collection
    {
        public string title { get; set; }
        public int tmdbId { get; set; }
    }

    public class Alternatetitle
    {
        public string sourceType { get; set; }
        public int movieMetadataId { get; set; }
        public string title { get; set; }
        public int id { get; set; }
    }

    public class Image
    {
        public string coverType { get; set; }
        public string url { get; set; }
        public string remoteUrl { get; set; }
    }

}
