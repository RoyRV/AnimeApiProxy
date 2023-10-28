using AnimeAPI.Core.Domain.Entities;

namespace AnimeDB.Adapter.Fixtures
{
  internal static class AnimeFixture
  {
    public static Anime OnePiece =
        new(
            1,
            "One Piece",
            "Follows the adventures of Monkey D. Luffy and his pirate crew in order to find the greatest treasure ever left by the legendary Pirate, Gold Roger",
            DateTime.Now,
            new() { GenreFixture.Comedy, GenreFixture.Action, GenreFixture.Adventure, }
        );

    public static Anime DrStone =
        new(
            2,
            "Dr. Stone",
            "Dr. Stone follows teen genius Senku Ishigami and his high school friend Taiju Oki as they work to rebuild civilization",
            new DateTime(2016, 05, 10),
            new()
            {
                    GenreFixture.Comedy,
                    GenreFixture.PostApocalyptic,
                    GenreFixture.ScienceFiction,
            }
        );

    public static Anime AttackOnTitan =
        new(
            3,
            "Attack on Titan",
            " After his hometown is destroyed and his mother is killed, young Eren Jaeger vows to cleanse the earth of the giant humanoid Titans that have brought humanity to the brink of extinction. Humans are nearly exterminated by giant creatures called Titans.",
            new DateTime(2012, 06, 19),
            new()
            {
                    GenreFixture.Terror,
                    GenreFixture.PostApocalyptic,
                    GenreFixture.Adventure,
            },
            new DateTime(2023, 10, 19)
        );
  };
}