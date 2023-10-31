using AnimeApi.Adapter.Repositories;
using AnimeProxyApi.Core.Application.Ports;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeApi.Adapter
{
  public static class Bootstrapper
  {
    public static void AddAnimeDB(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddScoped<IAnimeRepository, AnimeRepository>();
      serviceCollection.AddScoped<IGenreRepository, GenreRepository>();
    }
  }
}
