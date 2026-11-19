using TmdbApi.Models.Common;

namespace TmdbApi.Models.TvEpisodes;

public class TvEpisodeDetails
{
    public string? AirDate { get; set; }
    public Crew[]? Crew { get; set; }
    public int? EpisodeNumber { get; set; }
    public GuestStar[]? GuestStars { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public int Id { get; set; }
    public string? ProductionCode { get; set; }
    public int? Runtime { get; set; }
    public int? SeasonNumber { get; set; }
    public string? StillPath { get; set; }
    public double? VoteAverage { get; set; }
    public int? VoteCount { get; set; }
}
