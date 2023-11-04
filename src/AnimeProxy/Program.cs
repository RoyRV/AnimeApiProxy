
using AnimeApi.Adapter;
using AnimeApi.Adapter.Resources;
using AnimeProxy.Api;
using AnimeProxy.GraphQL;
using AnimeProxyApi.Core;

var builder = WebApplication.CreateBuilder(args);

const string APPPLICATION_NAME = "Anime-GraphQL";

builder.Services.AddAnimeDB(builder.Configuration.GetSection("AnimeApi").Get<ApiSettings>());
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