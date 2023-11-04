namespace AnimeProxyApi.Core.Infrastructure.Http
{
  public class HttpResponseResult<T>
  {
    public string Status { get; set; }

    public T Data { get; set; }

    public string Message { get; set; }

    public bool Error { get; set; }
  }
}