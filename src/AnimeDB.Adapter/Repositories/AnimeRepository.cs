using AnimeAPI.Core.Application.Ports;
using AnimeAPI.Core.Domain.Entities;
using AnimeDB.Adapter.Fixtures;

namespace AnimeDB.Adapter.Repositories
{
  internal sealed class AnimeRepository: IAnimeRepository
  {
    private readonly List<Anime> _list;

    public AnimeRepository()
    {
      _list = new()
            {
               AnimeFixture.OnePiece,
               AnimeFixture.DrStone,
               AnimeFixture.AttackOnTitan
            };
    }

    public Task<List<Anime>> Get()
    {
      return Task.FromResult(_list);
    }

    public Task<Anime?> Get(int id)
    {
      return Task.FromResult(_list.FirstOrDefault(item => item.Id == id));
    }
  }
}