using AnimeDB.Adapter;
using AnimeAPI.Core;
using AnimeApi.Api;

var builder = WebApplication.CreateBuilder(args);

const string APPPLICATION_NAME = "Anime-GraphQL";

builder.Services.AddAnimeDB();
builder.Services.AddCore(APPPLICATION_NAME);
builder.Services.AddApi();

var app = builder.Build();

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