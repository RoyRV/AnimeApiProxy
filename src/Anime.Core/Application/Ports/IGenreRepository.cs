using AnimeAPI.Core.Domain.Entities;

namespace AnimeAPI.Core.Application.Ports
{
  public interface IGenreRepository
  {
    public Task<List<Genre>> Get();
    public Task<Genre?> Get(int id);
  }
}
