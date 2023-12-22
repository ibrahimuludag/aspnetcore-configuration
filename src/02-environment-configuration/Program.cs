using Microsoft.Extensions.Configuration;

// Debug to see the effect of Environment Variable

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build();

var artist = configuration["Artist"];
var song = configuration["Song"];

Console.WriteLine($"{artist} - {song}");