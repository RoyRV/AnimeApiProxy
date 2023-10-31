

using AnimeProxyApi.Core.Domain.Entities;

namespace AnimeImageAPI.Adapter.Fixtures
{
  internal static class ImageFixture
  {
    public static Image OnePiece1 =
        new(1001, "One Piece", new("https://cdn.myanimelist.net/images/anime/10/66965l.jpg"));

    public static Image OnePiece2 =
        new(1002, "One Piece", new("https://cdn.myanimelist.net/images/anime/6/73245l.jpg"));

    public static Image DrStone1 =
        new(
            2001,
            "Dr. Stone",
            new("https://cdn.myanimelist.net/images/anime/1613/102576l.jpg")
        );
    public static Image DrStone2 =
        new(2002, "Dr. Stone", new("https://cdn.myanimelist.net/images/anime/1754/96428l.jpg"));

    public static Image AttackOnTitan1 =
        new(
            3001,
            "Attack on Titan",
            new("https://cdn.myanimelist.net/images/anime/10/47347l.jpg")
        );
    public static Image AttackOnTitan2 =
        new(
            3002,
            "Attack on Titan",
            new("https://cdn.myanimelist.net/images/anime/1907/134102l.jpg")
        );
  }
}