
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxy.GraphQL.Schema
{
  [ExtendObjectType("Query")]
  internal sealed class AnimeQuery
  {
    private readonly IAnimeRepository _repository;

    public AnimeQuery(IAnimeRepository repository)
    {
      _repository = repository;
    }

    public Task<List<Anime>> GetAnimes()
    {
      return _repository.GetAsync();
    }
  }
}
