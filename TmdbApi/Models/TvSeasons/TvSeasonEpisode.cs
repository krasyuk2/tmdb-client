using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvSeasons;

public class TvSeasonEpisode
{
    public string? AirDate { get; set; }
    public int? EpisodeNumber { get; set; }
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public string? ProductionCode { get; set; }
    public int? Runtime { get; set; }
    public int? SeasonNumber { get; set; }
    public int? ShowId { get; set; }
    public string? StillPath { get; set; }
    public double? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
    public Crew[]? Crew { get; set; }
    public GuestStar[]? GuestStars { get; set; }
}
