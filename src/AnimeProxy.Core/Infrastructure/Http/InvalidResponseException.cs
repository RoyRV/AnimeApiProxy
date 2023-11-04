namespace AnimeProxyApi.Core.Infrastructure.Http
{
  public class InvalidResponseException : Exception
  {
    public InvalidResponseException(string message, Exception innerException) : base(message, innerException)
    {

    }
  }
}