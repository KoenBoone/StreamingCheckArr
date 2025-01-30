// See https://aka.ms/new-console-template for more information

using Core;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

Settings settings;

try
{
    settings = new Settings();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.ReadLine();
    //quit the program
    Environment.Exit(0);
}

settings = new Settings();

var config = settings.getConfig();

//write all the config settings to the console
foreach (var item in config.AsEnumerable())
{
    Console.WriteLine(item);
}

//write the sonarrurl to the console
Console.WriteLine("test:" + config["AppSettings:SonarrUrl"]);

//write the radarrurl to the console
Console.WriteLine("test:" + config["AppSettings:RadarrUrl"]);

Console.ReadLine();