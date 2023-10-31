namespace AnimeProxyApi.Core.Domain.Entities
{
  public class Genre
  {
    public int Id { get; init; }

    public string Name { get; init; }

    public Genre(int id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}