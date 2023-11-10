namespace AnimeProxy.Shared.Exceptions
{
  public class InvalidResponseException : Exception
  {
    public InvalidResponseException(string message, Exception innerException) : base(message, innerException)
    {

    }
  }
}