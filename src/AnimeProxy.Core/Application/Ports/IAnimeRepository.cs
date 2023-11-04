using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeProxyApi.Core.Application.Ports
{
  public interface IAnimeRepository
  {
    Task<List<Anime>> GetAsync();
    Task<Anime?> Get(int id);
  }
}
