
using AnimeAPI.Core.Application.Ports;
using AnimeAPI.Core.Domain.Entities;

namespace AnimeApi.GraphQL.Schema
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
