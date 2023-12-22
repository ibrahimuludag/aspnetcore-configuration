using Microsoft.Extensions.Configuration;

// run dotnet run Song=Leviating

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .AddCommandLine(args)
    .Build();

var artist = configuration["Artist"];
var song = configuration["Song"];

// Get nested property
var age = configuration["Info:Age"];

Console.WriteLine($"{artist} - {song}");
Console.WriteLine($"Age : {age}");
