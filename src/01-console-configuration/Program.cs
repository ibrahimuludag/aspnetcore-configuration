using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .Build();

var artist = configuration["Artist"];
var song = configuration["Song"];

Console.WriteLine($"{artist} - {song}");