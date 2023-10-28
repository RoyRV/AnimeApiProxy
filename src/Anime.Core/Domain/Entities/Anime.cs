namespace AnimeAPI.Core.Domain.Entities
{
  public sealed class Anime
  {

    public int Id { get; init; }

    public string Title { get; init; }

    public string Description { get; init; }

    public DateTime StartDate { get; init; }

    public DateTime? EndDate { get; init; }

    public Image? Image { get; init; }

    public List<Genre> Genres { get; init; }

    public Anime(int id, string title, string description, DateTime startDate, List<Genre> genres)
    {
      Id = id;
      Title = title;
      Description = description;
      StartDate = startDate;
      Genres = genres;
    }

    public Anime(int id, string title, string description, DateTime startDate, List<Genre> genres, DateTime? endDate) : this(id, title, description, startDate, genres)
    {
      EndDate = endDate;
    }
  }
}