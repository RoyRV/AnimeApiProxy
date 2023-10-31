
using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxy.GraphQL.Schema
{
  public sealed class Queries
  {
    private readonly IAnimeRepository _repository;

    public Queries(IAnimeRepository repository)
    {
      _repository = repository;
    }

    public Task<List<Anime>> GetAnimes()
    {
      return _repository.Get();
    }
  }
}
