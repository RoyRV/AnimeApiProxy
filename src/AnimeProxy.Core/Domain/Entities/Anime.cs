using System.Text.Json.Serialization;

namespace AnimeProxyApi.Core.Domain.Entities
{
  public sealed class Anime
  {
    public Guid Id { get; init; }

    public string Title { get; init; }

    public string Description { get; init; }

    public DateTime StartDate { get; init; }

    public DateTime? EndDate { get; init; }

    //public Image? Image { get; init; }

    //public List<Genre> Genres { get; init; }

    [JsonConstructor]
    public Anime(Guid id, string title, string description, DateTime startDate)
    {
      Id = id;
      Title = title;
      Description = description;
      StartDate = startDate;
      //Genres = genres;
    }

    public Anime(Guid id, string title, string description, DateTime startDate, DateTime? endDate) : this(id, title, description, startDate)
    {
      EndDate = endDate;
    }
  }
}