namespace AnimeProxyApi.Core.Domain.Entities
{
  public sealed class Image
  {
    public Guid Id { get; init; }
    public Guid AnimeId { get; init; }
    public string Alt { get; init; }
    public Uri? Url { get; init; }
  }
}