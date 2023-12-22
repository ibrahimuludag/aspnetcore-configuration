using _04_api_configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var config = app.Services.GetRequiredService<IConfiguration>();
var songName = config["Song:Name"];

// Two ways to bind
// 01 - Get
var song = config.GetSection("Song").Get<Song>();

// 02 - Bind
var song2 = new Song();
config.GetSection("Song").Bind(song2);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
