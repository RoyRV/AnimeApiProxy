using AnimeApi.Adapter.ApiClient;
using AnimeApi.Adapter.Repositories;
using AnimeApi.Adapter.Resources;
using AnimeProxyApi.Core.Application.Ports;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeApi.Adapter
{
  public static class Bootstrapper
  {
    public static void AddAnimeDB(this IServiceCollection serviceCollection, ApiSettings settings)
    {
      serviceCollection.AddScoped<IAnimeRepository, AnimeRepository>();
      serviceCollection.AddScoped<IGenreRepository, GenreRepository>();


      serviceCollection.AddScoped<IAnimeApiClient, AnimeApiClient>();
      serviceCollection.AddHttpClient(ApiSettings.ClientName)
        .ConfigureHttpClient(httpClient =>
        {
          httpClient.BaseAddress = new Uri(settings.Host);
        });
    }
  }
}