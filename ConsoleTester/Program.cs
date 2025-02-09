// See https://aka.ms/new-console-template for more information

using Core;
using Microsoft.Extensions.Configuration;
using StreamingCheckArr.Core.Models;

Console.WriteLine("Hello, World!");

configParameters cp;

try
{
    cp = new configParameters();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.ReadLine();
    //quit the program
    Environment.Exit(0);
}

cp = new configParameters();

//write all the config settings to the console
Console.WriteLine(cp.ConnectionString);
Console.WriteLine(cp.SonarrIp + " port:" + cp.SonarrPort);
Console.WriteLine(cp.RadarrIp + " port:" + cp.RadarrPort);
Console.WriteLine(cp.SonarrApiKey);
Console.WriteLine(cp.RadarrApiKey);
Console.WriteLine(cp.TraktClientId);
Console.WriteLine(cp.TraktClientSecret);
Console.WriteLine(cp.TMDBApi);
Console.WriteLine(cp.TMDBToken);
Console.WriteLine(cp.CountryCode);

//get the series from sonarr
//var series = sc.getSeries().Result;
//var series = sc.lookupSeries("Bleu Bloods").Result;

//write the title of each series to the console
/*foreach (var s in series)
{
    Console.WriteLine(s.title + " " + s.year + " " + s.localPoster + " ---- " + s.remotePoster);
}*/

//check tmdb for outlander: id 56570
var tmdbclient = new tmdbClient();
var json = tmdbclient.getStreaming("tv", 56570, true);
Console.WriteLine(json.Result);



Console.ReadLine();