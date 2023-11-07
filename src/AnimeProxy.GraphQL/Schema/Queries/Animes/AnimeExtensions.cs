using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxy.GraphQL.Schema.Queries.Animes
{
  [ExtendObjectType(nameof(Anime))]
  internal class AnimeExtensions
  {
    public Task<List<Genre>> GetGenres([Parent] Anime anime, [Service] IGenreRepository repository) =>
      repository.GetGenresByIdsAsync(anime.Genres);

    public Task<List<Image>> GetImages([Parent] Anime anime, [Service] IImageRepository repository) =>
      repository.GetAsync(anime.Id);
  }
}