using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxyApi.Core.Application.Ports
{
  public interface IGenreRepository
  {
    Task<List<Genre>> GetGenresByIdsAsync(List<string> ids);
  }
}