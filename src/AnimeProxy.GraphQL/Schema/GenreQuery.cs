using AnimeProxyApi.Core.Application.Ports;
using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxy.GraphQL.Schema
{
  [ExtendObjectType("Query")]
  internal sealed class GenreQuery
  {
    private readonly IGenreRepository _repository;

    public GenreQuery(IGenreRepository repository)
    {
      _repository = repository;
    }

    public Task<List<Genre>> GetGenreByIdsAsync(List<string> ids)
    {
      return _repository.GetGenresByIdsAsync(ids);
    }
  }
}
