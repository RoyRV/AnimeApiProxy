using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxyApi.Core.Application.Ports
{
  public interface IGenreRepository
  {
    public Task<List<Genre>> Get();
    public Task<Genre?> Get(Guid id);
  }
}
