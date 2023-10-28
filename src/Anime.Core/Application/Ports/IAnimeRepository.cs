using AnimeAPI.Core.Domain.Entities;

namespace AnimeAPI.Core.Application.Ports
{
  public interface IAnimeRepository
  {
    public Task<List<Anime>> Get();
    public Task<Anime?> Get(int id);
  }
}
