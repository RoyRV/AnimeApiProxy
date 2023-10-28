namespace AnimeAPI.Core.Domain.Entities
{
  public sealed class Image
  {
    public int Id { get; init; }
    public string Title { get; init; }
    public Uri? Url { get; init; }

    public Image(int id, string title, Uri? url)
    {
      Id = id;
      Title = title;
      Url = url;
    }
  }
}