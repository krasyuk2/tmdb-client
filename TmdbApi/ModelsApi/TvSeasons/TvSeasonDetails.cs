using System.Text.Json.Serialization;

namespace TmdbApi.Models.TvSeasons;

public class TvSeasonDetails
{
    public string? AirDate { get; set; }
    public TvSeasonEpisode[]? Episodes { get; set; }
    public string? Name { get; set; }
    public string? Overview { get; set; }
    public int Id { get; set; }
    public string? PosterPath { get; set; }
    public int? SeasonNumber { get; set; }
    public double? VoteAverage { get; set; }
    [JsonPropertyName("_id")]
    public string? InternalId { get; set; }
}
