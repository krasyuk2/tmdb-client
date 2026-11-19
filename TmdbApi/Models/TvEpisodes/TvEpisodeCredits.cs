using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvEpisodes;

public class TvEpisodeCredits
{
    public Cast[]? Cast { get; set; }
    public Crew[]? Crew { get; set; }
    public GuestStar[]? GuestStars { get; set; }
    public int Id { get; set; }
}
