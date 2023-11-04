namespace AnimeProxyApi.Core.Infrastructure.Exceptions
{
  public class DependencyException : Exception
  {
    public string DependencyName { get; }

    public DependencyException(string dependecyName, string message, Exception innerException) : base(message, innerException)
    {
      DependencyName = dependecyName;
    }
  }
}