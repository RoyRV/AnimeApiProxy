using AnimeAPI.Core.Application.Ports;
using AnimeDB.Adapter.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeDB.Adapter
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
