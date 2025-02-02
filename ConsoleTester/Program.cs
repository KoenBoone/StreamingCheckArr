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
Console.WriteLine(cp.SonarrUrl);
Console.WriteLine(cp.RadarrUrl);
Console.WriteLine(cp.SonarrApiKey);
Console.WriteLine(cp.RadarrApiKey);
Console.WriteLine(cp.TraktClientId);
Console.WriteLine(cp.TraktClientSecret);
Console.WriteLine(cp.TMDBApi);
Console.WriteLine(cp.TMDBToken);
Console.WriteLine(cp.CountryCode);

Console.ReadLine();