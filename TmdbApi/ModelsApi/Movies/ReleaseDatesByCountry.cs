using System.Text.Json.Serialization;

namespace TmdbApi.Models.Movies;

public class ReleaseDatesByCountry
{
    [JsonPropertyName("iso_3166_1")]
    public string? Iso3166_1 { get; set; }
    public ReleaseDateEntry[]? ReleaseDates { get; set; }
}
