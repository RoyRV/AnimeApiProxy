namespace AnimeProxyApi.Core.Infrastructure.Exceptions
{
  public class InvalidResponseException : Exception
  {
    public InvalidResponseException(string message, Exception innerException) : base(message, innerException)
    {

    }
  }
}