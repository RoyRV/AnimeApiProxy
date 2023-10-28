using AnimeAPI.Core.Application.Ports;
using AnimeAPI.Core.Domain.Entities;
using AnimeDB.Adapter.Fixtures;

namespace AnimeDB.Adapter.Repositories
{
  internal sealed class GenreRepository : IGenreRepository
  {
    private readonly List<Genre> _list;

    public GenreRepository()
    {
      _list = new()
            {
              GenreFixture.Comedy,
              GenreFixture.Action,
              GenreFixture.Adventure,
              GenreFixture.Fantasy,
              GenreFixture.Terror
            };
    }

    public Task<List<Genre>> Get()
    {
      return Task.FromResult(_list);
    }

    public Task<Genre?> Get(int id)
    {
      return Task.FromResult(_list.FirstOrDefault(x => x.Id == id));
    }
  }
}