using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxyApi.Core.Application.Ports
{
  public interface IAnimeRepository
  {
    public Task<List<Anime>> Get();
    public Task<Anime?> Get(int id);
  }
}
