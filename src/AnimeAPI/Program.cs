using AnimeDB.Adapter;
using AnimeAPI.Core;
using AnimeApi.Api;
using AnimeApi.GraphQL;

var builder = WebApplication.CreateBuilder(args);

const string APPPLICATION_NAME = "Anime-GraphQL";

builder.Services.AddAnimeDB();
builder.Services.AddCore(APPPLICATION_NAME);
builder.Services.AddApi();
builder.Services.AddAnimeGraphQL();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints => endpoints.MapGraphQL());

app.Run();